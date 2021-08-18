using System;

namespace Interface
{
    class Program
    {
        abstract class Monster // 추상클래스
        {
            public abstract void Shout();
        } 

        interface IFlyable // 인터페이스
        {
            void Fly();
        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("록타를 오가르!");
            }
        }

        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {

            }
        }

        class Skeleton : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("꾸엑!");
            }
        }
         
        static void DoFly(IFlyable flyable)
        {
            flyable.Fly();
        }

        static void Main(string[] args)
        {
            IFlyable orc = new FlyableOrc();
            DoFly(orc);
        }
    }
}
