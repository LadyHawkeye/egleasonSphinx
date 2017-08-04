using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphinxRiddles
{
    class Program
    {
        public static bool first_question { get; private set; }
        public static bool second_question { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Greetings, traveler.");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("I am a great sphinx, and I challenge you to a game of wits.");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("You must answer my three riddles.");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Get it right and you may pass. Fail and I will devour you!");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Your first riddle...");
            System.Threading.Thread.Sleep(5000);
            {
                Console.WriteLine("I have a mouth but never eat");
                System.Threading.Thread.Sleep(1200);
                Console.WriteLine("Always run but never walk");
                System.Threading.Thread.Sleep(1200);
                Console.WriteLine("Have a bed but never sleep");
                System.Threading.Thread.Sleep(1200);
                Console.WriteLine("Often murmur but never talk");
                System.Threading.Thread.Sleep(1200);
                Console.WriteLine("What am I?");
                string a = Console.ReadLine().ToUpper();
                switch (a)
                {
                    case "A RIVER":
                        Console.WriteLine("Lucky Guess! Let's try another!");
                        first_question = true;
                        break;
                    case "RIVER":
                        Console.WriteLine("Lucky Guess! Let's try another!");
                        first_question = true;
                        break;
                    case "THE RIVER":
                        Console.WriteLine("Lucky Guess! Let's try another!");
                        first_question = true;
                        break;
                    default:
                        Console.WriteLine("Ha HA! Wrong!");
                        first_question = false;
                        break;
                }    
            }
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Your second riddle...");
            System.Threading.Thread.Sleep(5000);
            {
                Console.WriteLine("What is so fragile that speaking it's name breaks it?");
                string b = Console.ReadLine().ToUpper();
                switch (b)
                {
                    case "SILENCE":
                        {
                            if (first_question == false)
                            {
                                Console.WriteLine("Hmph, I was going easy on you anyways.");
                            }
                            else
                            {
                                Console.WriteLine("You think you're so clever, don't you.");
                            }
                        }
                        second_question = true;
                        break;
                    case "IT'S SILENCE":
                        {
                            if (first_question == false)
                            {
                                Console.WriteLine("Hmph, I was going easy on you anyways.");
                            }
                            else
                            {
                                Console.WriteLine("You think you're so clever, don't you.");
                            }
                        }
                        second_question = true;
                        break;
                    default:
                        {
                            if (first_question == false)
                            {
                                Console.WriteLine("Wrong again!");
                            }
                            else
                            {
                                Console.WriteLine("Ooooh, not so clever now, are we?");
                            }
                        }
                        second_question = false;
                        break;
                }
            }
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Your third riddle...");
            System.Threading.Thread.Sleep(5000);
            {
                Console.WriteLine("There are two sisters,");
                System.Threading.Thread.Sleep(1200);
                Console.WriteLine("The first gives birth to the second");
                System.Threading.Thread.Sleep(1200);
                Console.WriteLine("And the second gives birth to the first");
                System.Threading.Thread.Sleep(1200);
                Console.WriteLine("Who are they?");
                string c = Console.ReadLine().ToUpper();
                switch (c)
                {
                    case "DAY AND NIGHT":
                        if (second_question == true)
                        {
                            if (first_question == true)
                            {
                                Console.WriteLine("How?! My riddles should be impossible to guess!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I guess you get to pass, then.");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("Congratulations, you have passed the sphinx.");
                            }
                            else
                            {
                                Console.WriteLine("You missed one! Guess I get to eat you!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                        }
                        else
                        {
                            if (first_question == true)
                            {
                                Console.WriteLine("You missed one! Guess I get to eat you!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                            else
                            {
                                Console.WriteLine("Two wrong! I'll dine well today!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                        }
                        break;
                    case "NIGHT AND DAY":
                        if (second_question == true)
                        {
                            if (first_question == true)
                            {
                                Console.WriteLine("How?! My riddles should be impossible to guess!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I guess you get to pass, then.");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("Congratulations, you have passed the sphinx.");
                            }
                            else
                            {
                                Console.WriteLine("You missed one! Guess I get to eat you!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                        }
                        else
                        {
                            if (first_question == true)
                            {
                                Console.WriteLine("You missed one! Guess I get to eat you!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                            else
                            {
                                Console.WriteLine("Two wrong! I'll dine well today!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                        }
                        break;
                    case "DAY & NIGHT":
                        if (second_question == true)
                        {
                            if (first_question == true)
                            {
                                Console.WriteLine("How?! My riddles should be impossible to guess!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I guess you get to pass, then.");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("Congratulations, you have passed the sphinx.");
                            }
                            else
                            {
                                Console.WriteLine("You missed one! Guess I get to eat you!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                        }
                        else
                        {
                            if (first_question == true)
                            {
                                Console.WriteLine("You missed one! Guess I get to eat you!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                            else
                            {
                                Console.WriteLine("Two wrong! I'll dine well today!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                        }
                        break;
                    case "NIGHT & DAY":
                        if (second_question == true)
                        {
                            if (first_question == true)
                            {
                                Console.WriteLine("How?! My riddles should be impossible to guess!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I guess you get to pass, then.");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("Congratulations, you have passed the sphinx.");
                            }
                            else
                            {
                                Console.WriteLine("You missed one! Guess I get to eat you!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                        }
                        else
                        {
                            if (first_question == true)
                            {
                                Console.WriteLine("You missed one! Guess I get to eat you!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                            else
                            {
                                Console.WriteLine("Two wrong! I'll dine well today!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                        }
                        break;
                    default:
                        if (second_question == true)
                        {
                            if (first_question == true)
                            {
                                Console.WriteLine("Ha! You thought you were going to get away, didn't you!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                            else
                            {
                                Console.WriteLine("Two wrong! I'll dine well today!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                        }
                        else
                        {
                            if (first_question == true)
                            {
                                Console.WriteLine("Two wrong! I'll dine well today!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                            else
                            {
                                Console.WriteLine("All three wrong! I win! Now I shall eat you!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("I'm sorry, the sphinx has eaten you.");
                            }
                        }
                        break;
                }
            }
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
