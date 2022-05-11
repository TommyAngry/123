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
            int k= Convert.ToInt32(numberCoordinats.NumCoord(a,b)); //Blue Colour         
            //a = Convert.ToInt32(NumberCoordinats.NumCoord('B', 'C')); //Blue Colour
            //NumberCoordinats fMBotBlue = new();
            //b = Convert.ToInt32(NumberCoordinats.NumCoord('P', 'B'));//people Blue
            //NumberCoordinats fMPeopleRed = new();
            //c = Convert.ToInt32(NumberCoordinats.NumCoord('p', 'R'));//people Red
            //NumberCoordinats fMBotRed = new();
            //d = Convert.ToInt32(NumberCoordinats.NumCoord('M', 'y'));//machine red
            //NumberCoordinats fMBotRedColour = new();
            //e = Convert.ToInt32(NumberCoordinats.NumCoord('m', 'r'));//machine red
            //NumberCoordinats bot_enemy = new();
            //f = Convert.ToInt32(NumberCoordinats.NumCoord('b', 'e'));//bot enemy
            return k;
        }
    }
    }
     
