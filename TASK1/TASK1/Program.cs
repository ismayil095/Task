using System;

namespace TASK1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bal = 55;
            if (bal >= 91 && bal <= 100)
            {
                Console.WriteLine("Sizin aldiginiz qiymet: A");
            }
            else if (bal < 91 && bal >= 81)
            {
                Console.WriteLine("Sizin aldiginiz qiymet: B");
            }
            else if (bal < 81 && bal >= 71)
            {
                Console.WriteLine("Sizin aldiginiz qiymet: C");
            }
            else if (bal < 71 && bal >= 61)
            {
                Console.WriteLine("Sizin aldiginiz qiymet: D");
            }
            else if (bal < 61 && bal >= 51)
            {
                Console.WriteLine("Sizin aldiginiz qiymet: E");
            }
            else if (bal < 51 && bal >= 0)
            {
                Console.WriteLine("Sizin aldiginiz qiymet: F");
            }
            else
            {
                Console.WriteLine("Duzgun bal daxil edin");
            }
        }
    }
}
