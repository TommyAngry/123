using System;

namespace MyGame
{
    public class Person
    {
        public virtual string Name { get; set; }
        public virtual int MyChip { get; set; }
        public virtual int EnemyChip { get; set; }
    }
    public class People : Person
    {
        NumberCoordinats numberCoordinats = new(); 
            int mcp;
        public override string Name { get => "Player"; }
        public override int MyChip

        {
             get
            { return mcp; }
            set 
            {
               
                mcp = numberCoordinats.NumCoord('A','a');
                
            } 
        }
        int ecp;
        public override int EnemyChip
        {
            get
            { return ecp; }
            set
            {
               
                ecp = numberCoordinats.NumCoord('B', 'b');

            }
        }
    }
    public class Bot : Person
    {
        NumberCoordinats numberCoordinats = new();
        public override string Name { get => "bot"; }
        int mcp;
        public override int MyChip
        {
            get
            { return mcp; }
            set
            {
               
                mcp = numberCoordinats.NumCoord('D', 'd');

            }
        }
        int ecp;
        public override int EnemyChip
        {
            get
            { return ecp; }
            set
            {
               
               ecp = numberCoordinats.NumCoord('E', 'e');

            }
        }

    }

}
