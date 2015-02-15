using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Globalization;
using WhatsThisFilm.Service;

namespace WhatsThisFilm
{
    public partial class MainForm : Form
    {
        private MovieCache _cache;

        public MainForm(MovieCache cache)
        {
            InitializeComponent();
            _cache = cache;

            string currFilm = string.Empty;

            try
            {
                if ((currFilm = _cache.InitCache()) != string.Empty)
                {
                    ListeFilms.MouseWheel += new MouseEventHandler(ListeFilms_MouseWheel);
                    ListeFilms.KeyDown += new KeyEventHandler(ListeFilms_KeyDown);

                    RefreshList();
                }
                else
                {
                    btnBrowse_Click(this, null);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, currFilm);
                throw;
            }
        }

        void ListeFilms_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnWatchMovie_Click(this, null);
                    break;
            }
        }

        void ListeFilms_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ee = (HandledMouseEventArgs)e;

            if (e.Delta > 0)
            {
                ListeFilms_KeyDown(this, new KeyEventArgs(Keys.Up));
            }
            else
            {
                ListeFilms_KeyDown(this, new KeyEventArgs(Keys.Down));
            }
            ee.Handled = false;
        }



        private void RefreshList()
        {
            lblSrc.Text = _cache.searchPath;

            txtFiltre.Text = "";
            ListeFilms.DataSource = _cache.RefreshDataSource();
        }

        private void ListeFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            currIndex = 1;
            ListeFilms.Refresh();
            GetFilmInfos(true);
        }

        private int currIndex;
        private int maxIndex;

        private int GetFilmInfos(bool bIsAuto)
        {
            this.Cursor = Cursors.WaitCursor;

            FilmInfo finfo;
            if (_cache.containsFilmInfo(ListeFilms.SelectedItem.ToString()))
            {
                lblIndex.Text = currIndex.ToString();

                finfo = AlloClient.GetFromTitle(ListeFilms.SelectedItem.ToString(), currIndex);

                if (finfo != null)
                {
                    maxIndex = finfo.totalInSearch;

                    if (bIsAuto)
                    {
                        if ((finfo.titre != null) && maxIndex > 1)
                        {
                            //Stop if the film is ok with the file title
                            if (!IsOK(finfo))
                            {
                                if (currIndex != maxIndex)
                                {
                                    ++currIndex;
                                    btnPrev.Enabled = true;
                                    return GetFilmInfos(true);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                currIndex = 0;

                lblIndex.Text = currIndex.ToString();
                finfo = _cache.GetInfo(ListeFilms.SelectedItem.ToString()); 
            }
            if (finfo != null)
            {
                pictureBox1.Image = finfo.jaquette;
                lblYear.Text = finfo.year;
                lblTitle.Text = finfo.titre + " (" + finfo.HexedTitle + ")";
                lblDirector.Text = finfo.realisateur;
                lblResume.Text = finfo.synopsis;
                lblDuree.Text = finfo.duree;
                lblTotal.Text = finfo.totalInSearch.ToString();
                lnklblFiche.Text = finfo.link;
                lblGenres.Text = TitleManipulator.AddSpacesToSentence(finfo.genre);
                lblPresse.Text = finfo.presse + "/5";
            }
            else
            {
                SnipFiche();
            }

            _cache.SetInfo(ListeFilms.SelectedItem.ToString(), finfo);
           

            this.Cursor = Cursors.Arrow;
            return 1;
        }

        private void SnipFiche()
        {
            pictureBox1.Image = null;
            lblYear.Text = "----";
            lblTitle.Text = "---- (" + TitleManipulator.HexIt(ListeFilms.SelectedItem.ToString()) + ")";
            lblDirector.Text = "-";
            lblResume.Text = "-";
            lblDuree.Text = "-";
            lnklblFiche.Text = "-";
            maxIndex = 0;
            lblGenres.Text = "-";
            lblTotal.Text = "0";
            lblPresse.Text = "-";
        }

        private bool IsOK(FilmInfo finfo)
        {
            return TitleManipulator.flattenString(finfo.titre).Contains(TitleManipulator.flattenString(finfo.HexedTitle)) || TitleManipulator.flattenString(finfo.orig_titre).Contains(TitleManipulator.flattenString(finfo.HexedTitle));
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            --currIndex;
            btnNext.Enabled = true;

            if (currIndex < 2)
                btnPrev.Enabled = false;
            _cache.SetInfo(ListeFilms.SelectedItem.ToString(), null);
   
            GetFilmInfos(false);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currIndex != maxIndex)
            {
                ++currIndex;

                btnPrev.Enabled = true;
                _cache.SetInfo(ListeFilms.SelectedItem.ToString(), null);
                GetFilmInfos(true);
            }
            else
                btnNext.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            _cache.PersistCache();
        }

        private void btnWatchMovie_Click(object sender, EventArgs e)
        {
            Process.Start( _cache.GetFullPath(ListeFilms.SelectedItem.ToString()));
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();

            fb.Description = "Veuillez sélectionner un répertoire local ou réseau contenant des films";


            if (Directory.Exists(_cache.searchPath))
                fb.SelectedPath = _cache.searchPath;

            if (fb.ShowDialog() == DialogResult.OK)
            {
                _cache.searchPath = fb.SelectedPath;
                RefreshList();
            }
        }

        private void lnklblFiche_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lnklblFiche.Text);
        }

        private void logoBox_Click(object sender, EventArgs e)
        {
            Process.Start("www.allocine.fr");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void ListeFilms_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListControl li = sender as ListControl;

            e.DrawBackground();

            if (e.Index == li.SelectedIndex)
            {
                e.DrawFocusRectangle();
                e.Graphics.DrawString(ListeFilms.Items[e.Index].ToString(),
                                          e.Font, Brushes.White, e.Bounds,
                                          StringFormat.GenericDefault);
            }
            else
            {
                if (_cache.containsFilmInfo(ListeFilms.Items[e.Index].ToString()))
                {
                    e.Graphics.DrawString(ListeFilms.Items[e.Index].ToString(),
                                               e.Font, Brushes.Gray, e.Bounds,
                                               StringFormat.GenericDefault);


                }
                else
                {
                    e.Graphics.DrawString(ListeFilms.Items[e.Index].ToString(),
                                               e.Font, Brushes.Black, e.Bounds,
                                               StringFormat.GenericDefault);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (txtFiltre.Text != "")
            {
                ListeFilms.DataSource = _cache.FilterSource(txtFiltre);
            }
            else
                ListeFilms.DataSource = _cache.RawSource;

        }

        private void txtFiltre_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltre.Text.Length == 0)
                ListeFilms.DataSource = _cache.RawSource;
        }

        private void txtFiltre_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                btnFilter_Click(this, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _cache.ResetFilmInfo(ListeFilms.SelectedItem.ToString());

            SnipFiche();
        }
    }
}