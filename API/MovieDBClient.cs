using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DM.MovieApi;
using DM.MovieApi.MovieDb.Movies;
using DM.MovieApi.ApiResponse;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Drawing;
using System.Net;

namespace WhatsThisFilm.API
{
    internal class MovieDBClient
    {
        private string bearertoken = string.Empty;
        private IApiMovieRequest movieApi = null;

        private static Regex noHTMLreg = new Regex("<[^>]*>");

        private static MovieInfo currMovie;
        private static int currCount;

        internal MovieDBClient()
        {
            bearertoken = File.ReadAllText("themdbbearertoken.txt");
            MovieDbFactory.RegisterSettings(bearertoken);
            movieApi = MovieDbFactory.Create<IApiMovieRequest>().Value;
        }

        internal FilmInfo GetFromTitle(string movietitle, int index)
        {
            FilmInfo ans = new FilmInfo();
            string hexedTitle = TitleManipulator.HexIt(movietitle);

            ans.HexedTitle = hexedTitle;
            ans.Key = movietitle;

            //get full movie info
            Movie movie = null;
            Task.Run(async () =>
            {
                ApiQueryResponse<Movie> response = await movieApi.FindByIdAsync(currMovie.Id, "fr-FR");
                movie = response.Item;
            }).GetAwaiter().GetResult();

            ans.titre = currMovie.Title;
            ans.orig_titre = currMovie.OriginalTitle;
            ans.year = currMovie.ReleaseDate.Year.ToString();
            ans.synopsis = currMovie.Overview;
            ans.popularity = $"{currMovie.VoteAverage:0.#} / 10 ({currMovie.VoteCount:n} votes)";
            ans.link = $"https://www.themoviedb.org/movie/{currMovie.Id}";
            ans.allocinelink = $"https://www.allocine.fr/rechercher/?q={currMovie.Title}";
            if (movie.Genres != null)
            {
                foreach (var genre in movie.Genres)
                {
                    ans.genre += genre.Name + ", ";
                }
                ans.genre = ans.genre.TrimEnd(' ');
                ans.genre = ans.genre.TrimEnd(',');
            }

            if (currMovie.PosterPath != null)
            {
                ans.jaquette = BitmapFromWeb($"https://image.tmdb.org/t/p/w500/{currMovie.PosterPath}");
                ans.jaquetteTime = DateTime.Now;
            }


            //if (currMovie.CastingShort != null)
            //{
            //    ans.realisateur = currMovie.CastingShort.Directors;
            //}

            //if (currMovie.Statistics != null && currMovie.Statistics.PressRating != null)
            //{
            //    ans.presse = (double)currMovie.Statistics.PressRating;
            //}

            //ans.totalInSearch = currCount;
            //if (currMovie.LinkList != null && currMovie.LinkList.Count > 0)
            //    ans.link = currMovie.LinkList[0].Href;

            //if (currMovie.Runtime != null)
            //{
            //    ans.duree = TimeSpan.FromSeconds(int.Parse(currMovie.Runtime)).ToString();
            //}

            //ans.genre = "";
            //if (currMovie.GenreList != null)
            //{
            //    foreach (var genre in currMovie.GenreList)
            //    {
            //        ans.genre += genre.Value + ", ";
            //    }
            //    ans.genre = ans.genre.TrimEnd(' ');
            //    ans.genre = ans.genre.TrimEnd(',');
            //}
            //if (currMovie.SynopsisShort != null)
            //{
            //    ans.synopsis = currMovie.SynopsisShort.Replace("<br />", "\n").Replace("<br/>", "\n");
            //    ans.synopsis = noHTMLreg.Replace(ans.synopsis, "");
            //}

            //if (currMovie.Poster != null)
            //{
            //    ans.jaquette = BitmapFromWeb(currMovie.Poster.Href);
            //    ans.jaquetteTime = DateTime.Now;
            //}

            return ans;
        }

        internal FilmInfo GetFromTitleLight(string movietitle, int index)
        {
            FilmInfo ans = new FilmInfo();
            string hexedTitle = TitleManipulator.HexIt(movietitle);

            ans.HexedTitle = hexedTitle;
            ans.Key = movietitle;


            IReadOnlyList<MovieInfo> alFeed = null;
            Task.Run(async () =>
            {
                ApiSearchResponse<MovieInfo> response = await movieApi.SearchByTitleAsync(hexedTitle,1,"fr-FR");
                alFeed = response.Results;
            }).GetAwaiter().GetResult();

            if (alFeed != null && alFeed.Count >= index)
            {
                currCount = alFeed.Count;

                MovieInfo apiMovie = alFeed[index - 1];

                ans.titre = apiMovie.Title;

                currMovie = apiMovie;
            }
            else
            {
                currCount = 0;
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
