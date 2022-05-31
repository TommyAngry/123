using System;
namespace MyGame
{
    public class RecordData
    {
       
        /// <summary>
        /// a-фишки цвета человека, b-количество фишек своего цвета у игрока, с- количество фишек вражеских у человека, d-количество фишек бота, e- количесвто фишек своего цвета у юота
        /// f- количество фишек вражуских у бота
        /// </summary>
        public int  ChipsCountStart(char a,char b)
        {
            NumberCoordinats numberCoordinats = new();
            int k= Convert.ToInt32(numberCoordinats.NumCoord(a,b)); 
            return k;
        }
    }
    }
     
