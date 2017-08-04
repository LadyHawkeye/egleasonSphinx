using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphinxRiddles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings, traveler.");
            Console.WriteLine("I am a great sphinx, and I challenge you to a game of wits.");
            Console.WriteLine("You must answer my three riddles.");
            Console.WriteLine("Get it right and you may pass. Fail and I will devour you!");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Your first riddle...");
            System.Threading.Thread.Sleep(5000);
            {
                Console.WriteLine("I have a mouth but never eat");
                Console.WriteLine("Always run but never walk");
                Console.WriteLine("Have a bed but never sleep");
                Console.WriteLine("Often murmur but never talk");
                Console.WriteLine("What am I?");
                Console.WriteLine("(answer with one uncapitalized word)");
                Console.ReadLine();
                string a = Console.ReadLine().ToUpper();
                switch (a)
                {
                    case "A RIVER":
                    case "RIVER":
                }
                
            }
            Console.ReadKey();
        }
    }
}
