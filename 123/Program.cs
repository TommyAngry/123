using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FileData file = new();
            file.FileD(0, 0, 7, 0, 0, 7);
            while(true)
            {
                Logic logic = new();
                Console.WriteLine("1");
                //logic.Notify += Logic_Notify;
                Console.ReadLine();
                Logic logic1 = new Logic(1);
                Console.WriteLine("2");
                Console.ReadLine();
            }
            
        }

        //private static string Logic_Notify(string message)
        //{
        //    if(message.Equals("0"))
        //   return"Продолжаем игру";
        //    else
        //    {
        //       return$"{message}-Победитель";
        //    }
        //}

       
    }
}
