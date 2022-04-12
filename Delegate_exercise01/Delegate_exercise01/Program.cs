using System;

namespace Delegate_exercise01
{
    delegate int MyDelegate(int a, int b);    // delegate 선언

    class Calculator
    {
        public int Plus(int a, int b)         // delegate는 인스터스 메소드를 참조할수 있다.
        {
            return a + b;
        }

        public static int Minus(int a, int b) // delegate는 정적 메소드도 참조할수 있다.
        {
            return a - b;
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            // delegate 간단한 예제

            Calculator calculator = new();
            MyDelegate Callback;

            Callback = new MyDelegate(calculator.Plus);
            Console.WriteLine(Callback(3, 4));
                      
        }
    }
}
