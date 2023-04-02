using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;

namespace WhatsThisFilm
{
    public static class TitleManipulator
    {
        private static Regex statMovReg = new Regex(@"DVD.*" + "|" +
                                        @"AVI.*" + "|" +
                                        @"ogm.*" + "|" +
                                        @"x264.*" + "|" +
                                        @"sd.*" + "|" +
                                        @"www.*" + "|" +
                                        @"vf.*" + "|" +
                                        @"vvf.*" + "|" +
                                        @"SBK.*" + "|" +
                                        @"HD.*" + "|" +
                                        @"divx.*" + "|" +
                                        @"xvid.*" + "|" +
                                        @"ogg.*" + "|" +
                                        @"mkv.*" + "|" +
                                        @"Limite.*" + "|" +
                                        @"libertyland.*" + "|" +
                                        @"film.*" + "|" +
                                        @"movie.*" + "|" +
                                        @"cd[0-9].*" + "|" +
                                        @"cd-[0-9].*" + "|" +
                                        @"\[[^\[]*\]" + "|" +
                                        @"\([^\(]*\)" + "|" +
                                        @"\{[^\{]*\}" + "|" +
                                        @"NTSC.*" + "|" +
                                        @"VOS.*" + "|" +
                                        @"VO .*" + "|" +
                                        @"FR .*" + "|" +
                                        @"french.*" + "|" +
                                        @"truefrench.*" + "|" +
                                        @" TS .*" + "|" +
                                        @"MULTi.*" + "|" +
                                        @"RIP.*" + "|" +
                                        @"CAM.*" + "|" +
                                        @"AC3.*" + "|" +
                                        @"\|.*" + "|" +
                                        @" -.*" + "|" +
                                        @"19[0-9]{2}.*" + "|" +
                                        @"20[0-9]{2}.*", RegexOptions.IgnoreCase);

        public static string HexIt(string st)
        {
            st = Path.GetFileNameWithoutExtension(st);

            if (st.ToLower().Contains(" french "))
            {
                //kludge for the french dispatch
                return st;
            }

            //Remove . and _ and - by spaces
            st = Regex.Replace(st, "-|\\.|_", " ");
            //Convert the title
            st = statMovReg.Replace(st, "");
            //Remove extra spaces at the end of the string
            st = st.Trim();

            //Remove extra spaces within the string
            st = Regex.Replace(st, " +", " ");

            return RemoveDiacritics(st);
        }

        public static string RemoveDiacritics(string inputString)
        {
            String normalizedString = inputString.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < normalizedString.Length; i++)
            {
                Char c = normalizedString[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }
            return Regex.Replace(stringBuilder.ToString(), @"[^A-Za-z0-9_\-\.()]", " ");
        }

        /// <summary>
        /// Removes diactitics, then to lower
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string flattenString(string inputString)
        {
            return RemoveDiacritics(inputString).ToLower();
        }

        public static string AddSpacesToSentence(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            StringBuilder newText = new StringBuilder(text.Length * 2);
            newText.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                    newText.Append(' ');
                newText.Append(text[i]);
            }
            return newText.ToString();
        }
    }
}
