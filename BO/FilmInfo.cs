using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;

namespace WhatsThisFilm
{
    /// <summary>
    /// Class used to store film informations
    /// </summary>
    public class FilmInfo
    {
        internal string allocinelink;

        /// <summary>
        /// Name of the file
        /// </summary>
        public string Key { get; set; }
        
        /// <summary>
        /// Cleaned up title
        /// </summary>
        public string HexedTitle { get; set; }
        public string titre { get; set; }
        public string orig_titre { get; set; }
        public string realisateur { get; set; }
        public string year { get; set; }
        public string synopsis { get; set; }

        public string genre { get; set; }

        public string link { get; set; }

        internal int totalInSearch { get; set; }

        public string duree { get; set; }

        [XmlIgnore]
        public Bitmap jaquette { get; set; }

        public DateTime jaquetteTime { get; set; }

        public string popularity { get; set; }

        public string StringVal()
        {
            return titre + realisateur + year + genre + synopsis;
        }

        internal void reset()
        {
            this.jaquette = null;
            this.year = "-";
            this.titre = "-";
            this.realisateur = "-";
            this.synopsis = "-";
            this.duree = "-";
            this.link = "-";
            this.genre = "-";
            this.popularity = "-";
        }
    }

}
