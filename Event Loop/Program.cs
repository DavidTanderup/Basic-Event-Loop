using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.BasicEventLoop();
        }

        public void BasicEventLoop()
        {
            string prompt = "Options:\n\t1 - Attack\n\t2 - Defend\n\tq - Quit\nChoice: ";
            Console.Write(prompt);
            string input = Console.ReadLine();
            while (input != "q")
            {
                // try is 
                try
                {
                    int i = int.Parse(input);
                    Console.WriteLine($"Your input was {i}");
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid Input. Try again");
                }
                Console.Write(prompt);
                input = Console.ReadLine();
            }
        }


    }
}
