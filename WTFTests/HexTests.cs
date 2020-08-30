using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTFTests
{
    public class HexTests
    {
        public void HexResults()
        {
            DirectoryInfo dInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
            
            foreach(FileInfo fi in dInfo.GetFiles())
            {
                //Console.WriteLine("{0}\n{1}\n", fi.Name, TitleManipulator.HexIt(fi.Name));
            }
        }
    }
}
