using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    /// <summary>
    /// a-фишки имеющиеся у чела,B-вражескте фишки у человека,с-фишки чела на стола,d-фишки бота,е-вражеские фишки у бота,f-фишки бота на столе
    /// </summary>
    public class FileData
    {
        public  void FileD(int a, int b, int c, int d, int e, int f)
        {

            using (StreamWriter sr = new StreamWriter(@"C:\\Users\\Username\\Desktop\\writer.txt",
                false, Encoding.Default))
            {              
                sr.WriteLine($"A{a}a\nB{b}b\nC{c}c\nD{d}d\nE{e}e\nF{f}f");
            }

        }
    }
}
