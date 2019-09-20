using System;

namespace Deliverable_3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)

            {
                name(); 

            }
            void name()
            {
                Console.WriteLine("please provide your full name");
                string username = Console.ReadLine();
                Console.WriteLine("HELLO" + username + "!");

            }
        }
    }
}
