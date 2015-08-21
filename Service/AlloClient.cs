using AlloCine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace WhatsThisFilm.Service
{
    public class AlloClient
    {
        private static AlloCineApi api = new AlloCineApi();
        private static Regex noHTMLreg = new Regex("<[^>]*>");

        public static FilmInfo GetFromTitle(string title, int index)
        {
            FilmInfo ans = new FilmInfo();
            string hexedTitle = TitleManipulator.HexIt(title);

            ans.HexedTitle = hexedTitle;
            ans.Key = title;


            var alFeed = api.Search(hexedTitle, new[] { TypeFilters.Movie });

            if (alFeed.MovieList != null && alFeed.MovieList.Count >= index)
            {
                Movie apiMovie = alFeed.MovieList[index - 1];

                apiMovie = api.MovieGetInfo(apiMovie.Code, ResponseProfiles.Large, new[] { TypeFilters.Movie }, new[] { "synopsis" }, new[] { MediaFormat.Mpeg2 });

                ans.titre = apiMovie.Title;
                ans.orig_titre = apiMovie.OriginalTitle;
                ans.year = apiMovie.ProductionYear.ToString();
                if (apiMovie.CastingShort != null)
                { 
                    ans.realisateur = apiMovie.CastingShort.Directors;
                }

                if (apiMovie.Statistics != null)
                { 
                    ans.presse = (int)apiMovie.Statistics.PressRating;
                }

                ans.totalInSearch = alFeed.MovieList.Count;
                if (apiMovie.LinkList.Count > 0)
                    ans.link = apiMovie.LinkList[0].Href;

                if (apiMovie.Runtime != null)
                { 
                    ans.duree = TimeSpan.FromSeconds(int.Parse(apiMovie.Runtime)).ToString();
                }

                ans.genre = "";
                foreach (var genre in apiMovie.GenreList)
                {
                    ans.genre += genre.Value + ", ";
                }
                ans.genre = ans.genre.TrimEnd(' ');
                ans.genre = ans.genre.TrimEnd(',');

                if (apiMovie.SynopsisShort != null)
                { 
                    ans.synopsis = apiMovie.SynopsisShort.Replace("<br />", "\n").Replace("<br/>", "\n");
                    ans.synopsis = noHTMLreg.Replace(ans.synopsis, "");
                }

                if (apiMovie.Poster != null)
                {
                    ans.jaquette = BitmapFromWeb(apiMovie.Poster.Href);
                    ans.jaquetteTime = DateTime.Now;
                }
            }

            return ans;
        }

        private static Bitmap BitmapFromWeb(string URL)
        {
            try
            {

                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(URL);

                myRequest.Method = "GET";

                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();

                Bitmap bmp = new Bitmap(myResponse.GetResponseStream());
                myResponse.Close();

                return ResizeBitmap(bmp, 300, 400);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }
    }
}
