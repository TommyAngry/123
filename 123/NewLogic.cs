using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    //public class NewLogic
    //{
    //    People people = new People();
    //    TableChips tableChips = new TableChips();
    //    NumberCoordinats number = new NumberCoordinats();
    //    int mcP;
    //    //public virtual int a { get; set; }
    //    //int a2;
    //    //int virtualmyChip { get; set; }
       
    //    //public virtual int myEnemyChip {get;set;}
    //    //public virtual int  imposterChip;

    //    ////int virtual  myChipwithImposter;
    //    //public int MyChipOnTable;
    //    //public int EnemyChipOnTable;
    //    private  void Recorder(int a)
    //    {
    //        FileData fileData = new FileData();

            
    //        if (a == 1)
    //        {
    //            fileData.FileD(myChip, myEnemyChip, MyChipOnTable, imposterChip, myChipwithImposter, EnemyChipOnTable);
    //        }
    //        if (a == 0)
    //        {
    //            fileData.FileD(imposterChip, myChipwithImposter, EnemyChipOnTable, myChip, myEnemyChip, MyChipOnTable);
    //        }
    //    }
    //    //int MyTableChips {get { return MyTableChips; } set { MyTableChips = Record(a); } }
    //    //int EnemyTableChips { get { return EnemyTableChips; } set { if (MyTableChips == tableChips.People_Chips) EnemyTableChips = tableChips.Bot_Chips;
    //    //        else if (MyTableChips == tableChips.Bot_Chips) EnemyTableChips = tableChips.People_Chips;
    //    //    } }
    //    /// <summary>
    //    /// чтобы узнать количество оставшихся фишек на столе
    //    /// </summary>
    //    /// <param name="a"></param>
    //    /// <param name="b"></param>
    //    /// <returns></returns>
    //    public NewLogic(Person person0,Person person1)
    //    {
    //        myChip = number.NumCoord('D', 'd');
    //        myEnemyChip = number.NumCoord('E', 'e');
    //        myChipwithImposter = number.NumCoord('B', 'b');
    //        imposterChip = number.NumCoord('A', 'a');
    //        MyTableChips = number.NumCoord('F', 'f');
    //        MyTableChips = number.NumCoord('C', 'c');
    //        //if (a == 1)
    //        //{
    //        //    MyChipOnTable = tableChips.People_Chips;
    //        //    EnemyChipOnTable = tableChips.Bot_Chips;
    //        //}
    //        //if (a == 0)
    //        //{
    //        //    MyChipOnTable = tableChips.Bot_Chips;
    //        //    EnemyChipOnTable = tableChips.People_Chips;
    //        //}
    //        int RandB = Rand(1, 6);
    //        int RandA = Rand(1, 6);
    //        if (RandA == RandB)
    //        {
    //            EnemyColourPlus(RandA, a);

    //        }
    //        if (RandB > RandA)
    //        {
    //            B_Biggest_A(RandA, RandB, a);
    //        }
    //        if (RandB < RandA)
    //        {
    //            B_Biggest_A(RandA, RandB, a);
    //        }
    //    }
    //    public NewLogic(int a,Person person0,Person person1)
    //    {
    //        myChip = number.NumCoord('A','a') ;
    //        myEnemyChip = number.NumCoord('B', 'b');
    //        myChipwithImposter = number.NumCoord('E', 'e');
    //        imposterChip = number.NumCoord('D', 'd');
    //        MyTableChips = number.NumCoord('C', 'c');
    //        MyTableChips = number.NumCoord('F', 'f');


          
    //        int RandB = Rand(1, 6);
    //        int RandA = Rand(1, 6);
    //        if (RandA == RandB)
    //        {
    //            EnemyColourPlus(RandA, a);

    //        }
    //        if (RandB > RandA)
    //        {
    //            B_Biggest_A(MinusPlus(RandA,RandB), a);
    //        }
    //        if (RandB < RandA)
    //        {
    //            B_Biggest_A(RandA, RandB, a);
    //        }




    //    }
    //    /// <summary>
    //    /// для того чтобы перенести сюда количество фишек на столе
    //    /// </summary>
    //    /// <param name="a"></param>
    //    /// <returns></returns>
    //    public int RecordChipsOnTable(int a)
    //    {
    //        if (a == 1)
    //        {
    //            return tableChips.People_Chips;
    //        }
    //        if (a == 0)
    //        {
    //            return tableChips.Bot_Chips;

    //        }
    //        else
    //        {
    //            new Exception("Ошибка в record");
    //        }
    //        return 0;
    //    }
    //    /// <summary>
    //    /// сколько фишек своего цвета взять со стола?
    //    /// </summary>
    //    /// <param name="RandA"></param>
    //    /// <param name="RandB"></param>
    //    /// <param name="a"></param>
    //    /// <returns></returns>
    //    /// 
    //    private int  MinusPlus(int RandA,int RandB)
    //    {
    //        if(RandA>RandB)
    //        {
    //            int c = RandA - RandB;
    //            return c;
    //        }
    //        else
    //        {
    //            int c =RandB - RandA;
    //            return c;
    //        }
    //    }
    //    public void  B_Biggest_A(int cube, int a,int mtb)
    //    {
    //        if(cube>mtb)
    //        {
    //            mcP + mtb;
    //            mtb - mtb;
    //        }
    //        Recorder(a);
    //    }   
    //    /// <summary>
    //    /// рандом-кубики
    //    /// </summary>
    //    /// <param name="a"></param>
    //    /// <param name="b"></param>
    //    /// <returns></returns>
    //    public int Rand(int a, int b)
    //    {
    //        Random random = new Random();

    //        int Cube = random.Next(a, b);

    //        return Cube;
    //    }
    //    /// <summary>
    //    /// МЕТОД ДЛЯ ТОГО ЧТОБЫ МЕНЯТЬ КОЛИЧЕСТВО ПРИ ОДИНАКОВЫХ ЗНАЧЕНИЯХ КУБИКА
    //    /// </summary>
    //    /// <param name="EnemyChipsOnTable"></param>
    //    /// <param name="MyChipOnTable"></param>
    //    /// <param name="RandA"></param>
    //    /// <returns></returns>
    //    public void EnemyColourPlus(int RandA, int a)
    //    {
    //        if (EnemyChipOnTable != 0)
    //        {
    //            if (EnemyChipOnTable > RandA)
    //            {
    //                MyChipOnTable += RandA;
    //                EnemyChipOnTable -= RandA;

    //            }
    //            else if (EnemyChipOnTable < RandA)
    //            {
    //                MyChipOnTable += EnemyChipOnTable;
    //                EnemyChipOnTable -= EnemyChipOnTable;

    //            }

    //        }
    //        Recorder(a);
    //    }
    //    /// <summary>
    //    /// зависит запись в файл
    //    /// </summary>
    //    /// <param name="a"></param>
    //}
}
