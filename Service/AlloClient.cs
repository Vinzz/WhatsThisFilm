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

        private static Movie currMovie;
        private static int currCount;

        public static FilmInfo GetFromTitleLight(string title, int index)
        {
            FilmInfo ans = new FilmInfo();
            string hexedTitle = TitleManipulator.HexIt(title);

            ans.HexedTitle = hexedTitle;
            ans.Key = title;


            var alFeed = api.Search(hexedTitle, new[] { TypeFilters.Movie });

            currCount = alFeed.MovieList.Count;

            if (alFeed.MovieList != null && alFeed.MovieList.Count >= index)
            {
                Movie apiMovie = alFeed.MovieList[index - 1];

                apiMovie = api.MovieGetInfo(apiMovie.Code, ResponseProfiles.Large, new[] { TypeFilters.Movie }, new[] { "synopsis" }, new[] { MediaFormat.Mpeg2 });

                ans.titre = apiMovie.Title;

                currMovie = apiMovie;
            }

            return ans;
        }

        public static FilmInfo GetFromTitle(string title, int index)
        {
            FilmInfo ans = new FilmInfo();
            string hexedTitle = TitleManipulator.HexIt(title);

            ans.HexedTitle = hexedTitle;
            ans.Key = title;


            ans.titre = currMovie.Title;
            ans.orig_titre = currMovie.OriginalTitle;
            ans.year = currMovie.ProductionYear.ToString();
            if (currMovie.CastingShort != null)
            {
                ans.realisateur = currMovie.CastingShort.Directors;
            }

            if (currMovie.Statistics != null)
            {
                ans.presse = (int)currMovie.Statistics.PressRating;
            }

            ans.totalInSearch = currCount;
            if (currMovie.LinkList != null && currMovie.LinkList.Count > 0)
                ans.link = currMovie.LinkList[0].Href;

            if (currMovie.Runtime != null)
            {
                ans.duree = TimeSpan.FromSeconds(int.Parse(currMovie.Runtime)).ToString();
            }

            ans.genre = "";
            if (currMovie.GenreList != null)
            { 
                foreach (var genre in currMovie.GenreList)
                {
                    ans.genre += genre.Value + ", ";
                }
                ans.genre = ans.genre.TrimEnd(' ');
                ans.genre = ans.genre.TrimEnd(',');
            }
            if (currMovie.SynopsisShort != null)
            {
                ans.synopsis = currMovie.SynopsisShort.Replace("<br />", "\n").Replace("<br/>", "\n");
                ans.synopsis = noHTMLreg.Replace(ans.synopsis, "");
            }

            if (currMovie.Poster != null)
            {
                ans.jaquette = BitmapFromWeb(currMovie.Poster.Href);
                ans.jaquetteTime = DateTime.Now;
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
