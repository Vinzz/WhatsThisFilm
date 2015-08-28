using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using WhatsThisFilm.BO;
using WhatsThisFilm.Properties;

namespace WhatsThisFilm.Service
{
    public class MovieCache
    {
        private Dictionary<string, FilmInfo> _memory = new Dictionary<string, FilmInfo>();
        private UserData _userdata;

        public List<string> RawSource { get; set; }

        public string InitCache()
        {
            string firstFilmTitle = string.Empty;

            if (File.Exists(@".\cache\cache.xml"))
            {
                using (StreamReader sr = new StreamReader(@".\cache\cache.xml", true))
                {
                    XmlSerializer s = new XmlSerializer(typeof(UserData));

                    // Load cached info
                    _userdata = (UserData)(s.Deserialize(sr));

                    // gently migrate single searchPath list
                    if (_userdata.searchPathsList.Count == 0)
                    {
                        _userdata.searchPathsList.Add(_userdata.searchPath);
                    }
                }

                firstFilmTitle = CleanUpCache();
            }
            else
            {
                _userdata = new UserData();
            }

            return firstFilmTitle;
        }

        private string CleanUpCache()
        {
            string firstFilmTitle = string.Empty;

            List<FilmInfo> iToRemove = new List<FilmInfo>();
            foreach (FilmInfo f in _userdata.list)
            {
                if (f != null)
                {
                    // cache migration
                    if ((f.titre == "Il est temps de mettre à jour votre application")
                        || (f.realisateur == null))
                    {
                        iToRemove.Add(f);
                        continue;
                    }
                    firstFilmTitle = f.HexedTitle;
                    _memory[f.Key] = f;

                    string picName = @".\cache\" + f.Key + ".jpg";
                    if (File.Exists(picName))
                    {
                        using (FileStream stream = new FileStream(picName, FileMode.Open, FileAccess.Read))
                        {
                            Debug.WriteLine(picName);
                            var bmp = new Bitmap(stream);
                           _memory[f.Key].jaquette = (Bitmap)bmp.Clone();
                            Debug.WriteLine("Success");
                        }

                        _memory[f.Key].jaquetteTime = new FileInfo(picName).LastWriteTime;
                    }
                    else
                        if (_memory[f.Key].titre != "-")
                            _memory[f.Key] = null;

                }
            }

            foreach (FilmInfo f in iToRemove)
                _userdata.list.Remove(f);
            return firstFilmTitle;
        }

        internal void ResetFilmInfo(string stFilmToReset)
        {
            _memory[stFilmToReset].reset();
        }

        internal List<String> FilterSource(System.Windows.Forms.TextBox txtFiltre)
        {
            List<String> filteredSource = new List<string>();

            foreach (string s in RawSource)
            {
                if ((_memory.ContainsKey(s) == true) && (_memory[s] != null))
                {
                    if (TitleManipulator.RemoveDiacritics(_memory[s].StringVal().ToLower()).Contains(TitleManipulator.RemoveDiacritics(txtFiltre.Text.ToLower())))
                        filteredSource.Add(s);
                }
            }

            return filteredSource;
        }

        internal List<string> RefreshDataSource(int chosenPath)
        {
            _userdata.searchPath = _userdata.searchPathsList[chosenPath];
            DirectoryInfo diSource = new DirectoryInfo(_userdata.searchPath);

            RawSource = new List<string>();
            foreach (FileInfo fi in diSource.GetFiles())
            {
                if (Settings.Default.VideoExtensions.Contains(fi.Extension))
                    RawSource.Add(fi.Name);
            }

            return RawSource;
        }

        public string searchPath
        {
            get
            {
                return _userdata.searchPath;
            }

            set
            {
                _userdata.searchPath = value;
            }
        }

        public List<string> searchPathList
        {
            get
            {
                return _userdata.searchPathsList;
            }

            set
            {
                _userdata.searchPathsList = value;
            }
        }

        internal bool doesnotContainsFilmInfo(string p)
        {
            if ((_memory.ContainsKey(p) == false) || _memory[p] == null)
            {
                return true;
            }

            if (_memory[p].titre == "-")
            {
                return true;
            }

            return false;
        }

        internal FilmInfo GetInfo(string p)
        {
            return _memory[p];
        }

        internal void SetInfo(string p, FilmInfo finfo)
        {
            _memory[p] = finfo;
        }

        internal void PersistCache()
        {
            try
            {
                XmlSerializer s = new XmlSerializer(typeof(UserData));

                if (!Directory.Exists(@".\cache\"))
                    Directory.CreateDirectory(@".\cache\");

                System.IO.TextWriter xw = new System.IO.StreamWriter(@".\cache\cache.xml", false, System.Text.Encoding.UTF8);

                _userdata.list = new List<FilmInfo>();
                foreach (FilmInfo f in _memory.Values)
                {
                    if (f != null && (f.jaquette != null))
                    {
                        try
                        {
                            bool bSavePic = true;

                            // Do not save an up to date image
                            if (File.Exists(@".\cache\" + f.Key + ".jpg"))
                            {
                                if (f.jaquetteTime == new FileInfo(@".\cache\" + f.Key + ".jpg").LastWriteTime)
                                    bSavePic = false;
                            }

                            if (bSavePic)
                                f.jaquette.Save(@".\cache\" + f.Key + ".jpg", ImageFormat.Jpeg);
                        }
                        catch (Exception)
                        {
                        }
                    }
                    _userdata.list.Add(f);
                }
                s.Serialize(xw, _userdata);
                xw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WTF - Erreur");
            }
        }

        internal string GetFullPath(string p)
        {
            return Path.Combine(_userdata.searchPath, p);
        }

        internal void SnipFromDataSource(int p)
        {
            // TODO add warning and snip cache?
            _userdata.searchPathsList.RemoveAt(p);
            _userdata.searchPath = _userdata.searchPathsList.Count > 0 ? _userdata.searchPathsList[0] : string.Empty;
        }

        internal void RenameFile(string key)
        {
            var filmInfo = _memory[key];

            string newName = filmInfo.titre + Path.GetExtension(key);

            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
            {
                newName = newName.Replace(c, '_');
            }

            File.Move(GetFullPath(filmInfo.Key), GetFullPath(newName));
            filmInfo.Key = filmInfo.titre;
            _memory[newName] = filmInfo;

            //Remove old reference
            _memory.Remove(key);
        }

        internal void PersistAndCleanUpCache()
        {
            PersistCache();

            List<string> actualMovie = new List<string>();

            foreach (string s in _userdata.searchPathsList)
            {
                foreach(string f in (Directory.GetFiles(s)))
                {
                    actualMovie.Add(Path.GetFileName(f));
                }
            }

            foreach(var file in Directory.GetFiles(@".\cache\","*.jpg"))
            {
                string picName = Path.GetFileNameWithoutExtension(file);

                if(!_memory.ContainsKey(picName))
                {
                    File.Delete(file);
                }
                else
                {
                    if(!actualMovie.Contains(picName))
                    {
                        File.Delete(file);
                        _memory.Remove(picName);
                    }
                }
            }

            PersistCache();
        }
    }
}
