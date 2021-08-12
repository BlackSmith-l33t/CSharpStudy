using System;
using System.Diagnostics;

namespace Part1_exercise_1
{
    class Program
    {

        static int GetHighestScore(int[] scroes)
        {
            int maxValau = 0;

            for (int i = 0; i < scroes.Length; i++)
            {
                if (maxValau < scroes[i])
                {
                    maxValau = scroes[i];
                }
            }
            return maxValau;
        }

        static int GetAverageScore(int[] scroes)
        {
            int sum = 0;            

            for (int i = 0; i < scroes.Length; i++)
            {
                sum += scroes[i];
            }
            return sum / scroes.Length;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            int result = 0;

            for (int i = 0; i < scores.Length; i++) 
            {
                if (value == scores[i])
                {
                     result = scores[i];
                }
            }
            return result;
        }

        static void Sort(int[] scores)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int temp1;

            for (int i = 0; i < scores.Length; i++)
            {
                temp1 = scores[i];
                for (int j = 0; j < scores.Length; j++)
                {
                    if (temp1 < scores[j])
                    {
                        temp1 = scores[j];
                        scores[j] = scores[i];
                        scores[i] = temp1;
                    }
                }
            }
            stopwatch.Stop();
            System.Console.WriteLine("time : " + stopwatch.Elapsed.TotalMilliseconds + "ms");            

        }

        static void Main(string[] args)
        {
            // 배열
            int[] scroes = new int[5] { 10, 30, 40, 20, 50 };
          
            Console.WriteLine($"{GetHighestScore(scroes)}");
            Console.WriteLine($"{GetAverageScore(scroes)}");
            Console.WriteLine($"{GetIndexOf(scroes, 40)}");
            
            Sort(scroes);
            
            foreach(int n in scroes)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
