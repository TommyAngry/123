using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{

    public class Logic
    {
       
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
            int randA = Rand(1, 5);
            int randB = Rand(1, 5);
            int result = CubeAreEqual(randA, randB);
            switch (result == 0)
            {
                case true:
                    {
                        int a = CubeNoEqual(randA, randB);
                        if(MyTable>0)
                        {
                            switch (MyTable > a||MyTable==a)
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
                          
                        }
                        else
                        {
                            NoTableChips(0);
                        }
                        break;

                    }
                case false: 
                    if(EnemyTable>0||EnemyTable==result)
                    {
                        if (result > EnemyTable)
                        {
                            MyEnemyChip += EnemyTable;
                            EnemyTable -= result;
                        }
                        else
                        {
                            MyEnemyChip += EnemyTable;
                            EnemyTable -= EnemyTable;
                        }
                    }
                    else
                    {
                        NoTableChips(1);
                    }
                 
                    break;

            }
            fileData.FileD(MyChip, MyEnemyChip, MyTable, EnemyChip, MyChipWithEnemy, EnemyTable);
           
            End(people.Name,bot.Name);
           
        }

        private void NoTableChips(int a )
        {
            if(a==0)
            {
                Console.WriteLine("На столе нету фишек своего цвета\n ход за противником");
            }
            if (a == 1)
            {
                Console.WriteLine("На столе нету фишек другого цвета\n ход за противником");
            }


        }
        int endwhile;
        public void End(string MyName, string EnemyName)
        {
            switch (MyTable + EnemyTable == 0)
            {
                case true:
                    if (MyChip + MyEnemyChip > MyChipWithEnemy + EnemyChip)
                    {
                        Console.WriteLine($"{MyName}-победитель-фишек у него своих{MyChip}\n чужих {MyEnemyChip}");
                       endwhile=1;
                    }
                    else if (MyChip + MyEnemyChip < MyChipWithEnemy + EnemyChip)
                    {
                        Console.WriteLine($"{EnemyName}-победитель-фишек у него своих{EnemyChip}\n чужих {MyChipWithEnemy}");
                        endwhile = 1;
                    }
                    else if (MyChip + MyEnemyChip == MyChipWithEnemy + EnemyChip)
                    {
                        Console.WriteLine($"{EnemyName}--фишек у него своих{EnemyChip}\n чужих {MyChipWithEnemy }\n ничья");
                        endwhile = 1;
                    }
                    break;
                default: Console.WriteLine($"Фишек у {MyName}своего цвета-{MyChip},вражеского-{MyEnemyChip}\nФИШЕК У {EnemyName} СВОИХ - {EnemyChip},вРАЖЕСКИХ - {MyChipWithEnemy}"); endwhile = 0; break;
            }  }

        public int EndWhile()
        {
            return endwhile;
        }

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
                        if (MyTable > 0)
                        {
                            switch (MyTable > a1||MyTable==a1)
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

                        }
                        else
                        {
                            NoTableChips(0);
                        }
                        break;

                    }
                case false:
                    if (EnemyTable > 0||EnemyTable==result)
                    {
                        if (result > EnemyTable)
                        {
                            MyEnemyChip += EnemyTable;
                            EnemyTable -= result;
                        }
                        else
                        {
                            MyEnemyChip += EnemyTable;
                            EnemyTable -= EnemyTable;
                        }
                    }
                    else
                    {
                        NoTableChips(1);
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
            int c;
            if (a < 0 || b < 0)
            {
                new Exception("Введите корректное число");
                return -100;
            }
            else if (a>b)
            {
                return c=a - b; 
            }
            else if(a<b)
            {
               
                return  c = b - a;
            }
          
            return -100;

        }
        public int CubeAreEqual(int a,int b)
        {
            if(a<0||b<0)
            {
               
                return -100;
            }
            switch(a==b)
            {
                case true:return a;
                default:return 0;
            }
            
        }
    }
}
