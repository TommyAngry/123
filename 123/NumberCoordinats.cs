using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MyGame
{
   public  class NumberCoordinats
    {
   
        /// <summary>
        /// Метод который берет значение числа из файла по координатам
        /// </summary>
        /// <param name="letter1"></param>
        /// <param name="letter2"></param>
        /// <returns></returns>
        public  int NumCoord(char letter1, char letter2)
        {
            using (StreamReader streamReader = new StreamReader(@"C:\\Users\\Username\\Desktop\\writer.txt", System.Text.Encoding.Default))
            {
                string CountS = streamReader.ReadToEnd();
                string startletters = Convert.ToString(CountS.IndexOf(letter1));
                int StartIndex = Convert.ToInt32(startletters);

                string lastLetters = Convert.ToString(CountS.LastIndexOf(letter2));
                int LastIndex = Convert.ToInt32(lastLetters);

                string Numbers = CountS.Substring(StartIndex + 1, LastIndex - (StartIndex + 1));
                int k = Convert.ToInt32(Numbers);

                return k;

            }


       


        }
        /// <summary>
        /// меняет цифру 
        /// </summary>
        /// <param name="letter1"></param>
        /// <param name="letter2"></param>
        /// <param name="a"></param>
        public static void NumReplace(char letter1, char letter2,int a)
        {
            using (StreamReader streamReader = new StreamReader(@"C:\\Users\\Username\\Desktop\\writer.txt", System.Text.Encoding.Default))
            {
                string CountS = streamReader.ReadToEnd();
                string startletters = Convert.ToString(CountS.IndexOf(letter1));
                int StartIndex = Convert.ToInt32(startletters);

                string lastLetters = Convert.ToString(CountS.LastIndexOf(letter2));
                int LastIndex = Convert.ToInt32(lastLetters);

                string Numbers = CountS.Substring(StartIndex + 1, LastIndex - (StartIndex + 1));
                Numbers.Replace(Numbers, $"{a}");


                

            }


        }


    }
}

