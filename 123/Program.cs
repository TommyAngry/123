using System;

namespace MyGame
{
    class Program
    {
        Bot bot = new();
        People people = new();
       
        static void Main(string[] args)
        {
            
            FileData file = new();
            file.FileD(0, 0, 7, 0, 0, 7);
            while(true)
            {
                Logic logic = new();
                Console.WriteLine("1");
               
                Console.ReadLine();
                if (logic.EndWhile() == 1)              
                    break;

                Logic logic1 = new Logic(1);
                Console.WriteLine("2");
                
                Console.ReadLine();
                if (logic.EndWhile() == 1)
                    break;
            }
            
        }

      
       
    }
}
