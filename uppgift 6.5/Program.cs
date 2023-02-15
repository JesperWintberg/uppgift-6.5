using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            längd("3","54");

        }

        static void längd(string ord1,string ord2)
        {
            if (ord1.Length > ord2.Length)
            {
                Console.WriteLine($"{ord1} är längre en {ord2}");
            }

            else if (ord1.Length < ord2.Length)
            {
                Console.WriteLine($"{ord2} är längre än {ord1}");
            }

            else
            {
                Console.WriteLine($"{ord1} och {ord2} är lika långa");
            }
        }
    }
}

