using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{

    public class Logic
    {
        public  delegate string GameOver(string message);
        public event GameOver Notify;
        People people = new();
        Bot bot = new();
        NumberCoordinats number = new();
        FileData fileData = new();
        int MyChip;
        int MyEnemyChip;
        int MyTable;
        int EnemyChip;
        private int MyChipWithEnemy;
        private int EnemyTable;

        public Logic()
        {
            MyChip = number.NumCoord('A', 'a');
            MyEnemyChip = number.NumCoord('B', 'b');
            MyTable = number.NumCoord('C', 'c');
            EnemyChip = number.NumCoord('D', 'd');
            MyChipWithEnemy = number.NumCoord('E', 'e');
            EnemyTable = number.NumCoord('F', 'f');
            int randA = Rand(1, 6);
            int randB = Rand(1, 6);
            int result = CubeAreEqual(randA, randB);
            switch (result == 0)
            {
                case true:
                    {
                        int a = CubeNoEqual(randA, randB);
                        switch (MyTable > a)
                        {
                            case true:
                                MyChip += a;
                                MyTable -= a;
                                break;
                            case false:
                                MyChip += MyTable;
                                MyTable -= MyTable;
                                break;
                        }
                        break;
                    }
                case false: if (result > EnemyTable)
                    {
                        MyEnemyChip += result;
                        EnemyTable -= result;
                    }
                    else
                    {
                        MyEnemyChip += EnemyTable;
                        EnemyTable -= EnemyTable;
                    }
                    break;

            }
            fileData.FileD(MyChip, MyEnemyChip, MyTable, EnemyChip, MyChipWithEnemy, EnemyTable);
           
            End(people.Name,bot.Name);
        }
        public void End(string MyName, string EnemyName)
        {
            switch (MyTable + EnemyTable == 0)
            {
                case true:
                    if (MyChip + MyEnemyChip > MyChipWithEnemy + EnemyChip)
                    {
                        Console.WriteLine($"{MyName}-победитель");

                    }
                    else if (MyChip + MyEnemyChip < MyChipWithEnemy + EnemyChip)
                    {
                        Console.WriteLine($"{EnemyName}-победитель");
                    }
                    Console.WriteLine("Game over");
                    break;
                default: Console.WriteLine("Далее"); break;
            }  }
            //public void End(string MyName, string EnemyName )
            //{

            //   switch(MyTable+EnemyTable==0)
            //    {
            //        case true:
            //            if (MyChip + MyEnemyChip > MyChipWithEnemy + EnemyChip)
            //            {
            //                Notify.Invoke($"{MyName}");

            //            }
            //            else if (MyChip + MyEnemyChip < MyChipWithEnemy + EnemyChip)
            //            {
            //                Notify.Invoke($"{EnemyName}");
            //            }
            //            Console.WriteLine("Game over");
            //            break;
            //        default: Console.WriteLine("Далее"); break;
            //    }


            //}
            public Logic(int a)
        {
            MyChip = number.NumCoord('D', 'd');
            MyEnemyChip = number.NumCoord('E', 'e');
            MyTable = number.NumCoord('F', 'f');
            EnemyChip = number.NumCoord('A', 'a');
            MyChipWithEnemy = number.NumCoord('B', 'b');
            EnemyTable = number.NumCoord('C', 'c');
            int randA = Rand(1, 6);
            int randB = Rand(1, 6);
            int result = CubeAreEqual(randA, randB);
            switch (result == 0)
            {
                case true:
                    {
                        int a1 = CubeNoEqual(randA, randB);
                        switch (MyTable > a1)
                        {
                            case true:
                                MyChip += a1;
                                MyTable -= a1;
                                break;
                            case false:
                                MyChip += MyTable;
                                MyTable -= MyTable;
                                break;
                        }
                        break;
                    }
                case false:
                    if (result > EnemyTable)
                    {
                        MyEnemyChip += result;
                        EnemyTable -= result;
                    }
                    else
                    {
                        MyEnemyChip += EnemyTable;
                        EnemyTable -= EnemyTable;
                    }
                    break;

            }
            fileData.FileD( EnemyChip, MyChipWithEnemy, EnemyTable,MyChip, MyEnemyChip, MyTable);
            End(bot.Name,people.Name);            
        }
        public int Rand(int a, int b)
        {
            Random random = new Random();

            int Cube = random.Next(a, b);

            return Cube;
        }
        public int CubeNoEqual(int a,int b)
        {
            if(a>b)
            {
                return a - b; 
            }
            else
            {
                return b - a;
            }
        }
        public int CubeAreEqual(int a,int b)
        {
            switch(a==b)
            {
                case true:return a;
                default:return 0;
            }
            
        }
    }
}
