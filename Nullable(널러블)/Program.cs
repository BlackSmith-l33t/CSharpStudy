using System;

namespace Nullable_널러블_
{
    class Program
    {
        static int Find()
        {
            return 0;
        }

        class Monster
        {
            public int Id { get; set; }
        }

        static void Main(string[] args)
        {
            // Nullable -> Null+  able
            // Nullable -> 형식?
            // null
            // ??
            // ?.

            int? number = 5;

            if (number != null)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            if (number.HasValue)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            int b = number ?? 0;
            int c = (number != null) ? number.Value : 0;


            Monster monster = null;

            if (monster != null)
            {
                int monsterId = monster.Id;
            }

            int? id = monster?.Id;
            
            if (monster == null)
            {
                id = null; 
            }
            else
            {
                id = monster.Id;
            }
                      
        }
    }
}
