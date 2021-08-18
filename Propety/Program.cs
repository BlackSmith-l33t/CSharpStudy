using System;

namespace Propety
{
    class Program
    {
        // 객체지향 -> 은닉성
        class Knight
        {
            protected int hp;

            public int Hp // int Hp { get; set; } = 100; 
            {
                get { return hp; }  
                set { hp = value; }

                //get; 
                //set;               
            } 
        }

        static void Main(string[] args)
        {
            // 프로퍼티
            Knight knight = new Knight();
            knight.Hp = 100;

            int hp = knight.Hp;
        }
    }
}
