using System;

namespace oop_conding_style
{ 
    class Player // 부모 / 기반
    {        
        protected int hp;
        protected int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출!");
        }

        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }
    // 오버로딩(함수 이름의 재상용) , 오버라이딩(다형성)

    class Knight : Player
    {
        public Knight() : base(100)
        {
            Console.WriteLine("Knight 생성자 호출");
        }

        static public Knight CreatKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;           
            return knight;
        }

        public override void Move()
        {
            Console.WriteLine("Knight 이동!");
        }
    }

    class Mage : Player
    {
        public int mp;

        public Mage() : base(100)
        {
            Console.WriteLine("Mage 생성자 호출");
        }

        static public Mage CreatMage()
        {
            Mage Mage = new Mage();
            Mage.hp = 100;
            Mage.attack = 1;
            return Mage;
        }

        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }

    class Program
    {
        static void EnterGame(Player player)
        {
            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
            }        

        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            knight.Move();
            mage.Move();

            EnterGame(mage);
        }
    }
}
