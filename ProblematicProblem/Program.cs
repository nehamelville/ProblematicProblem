
using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
     class Program
    {
        static Random rng = new Random();
        static bool cont = true;

        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        static void Main(string[] args)
        {
            string cont = "";
            do
            {

                Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
                cont = (Console.ReadLine());
                if (cont.ToLower() != "yes")
                {
                    Console.WriteLine("You are exiting the program");
                    return;
                }
                Console.WriteLine();

                Console.Write("We are going to need your information first! What is your name? ");
                string userName = Console.ReadLine();

                Console.WriteLine();

                Console.Write("What is your age? ");
                int userAge = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
                string seeList = Console.ReadLine();

                if (seeList.ToLower() == "sure")
                {
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    string addToList = "";


                    Console.WriteLine();
                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                    addToList = Console.ReadLine();
                    if (addToList.ToLower() == "yes")
                    {
                        do
                        {

                            Console.WriteLine();

                            Console.Write("What would you like to add? ");
                            string userAddition = Console.ReadLine();

                            activities.Add(userAddition);

                            foreach (string activity in activities)
                            {
                                Console.Write($"{activity} ");
                                Thread.Sleep(250);
                            }

                            Console.WriteLine();
                            Console.WriteLine("Would you like to add more? yes/no: ");
                            addToList = Console.ReadLine();
                        } while (addToList.ToLower() == "yes");
                    }



                }

                while (cont == "yes")
                {
                    Console.Write("Connecting to the database");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }

                    Console.WriteLine();

                    Console.Write("Choosing your random activity");

                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }

                    Console.WriteLine();


                    int randomNumber = rng.Next(activities.Count);

                    string randomActivity = activities[randomNumber];

                    if (userAge > 21 && randomActivity == "Wine Tasting")
                    {
                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                        Console.WriteLine("Pick something else!");

                        activities.Remove(randomActivity);

                        randomNumber = rng.Next(activities.Count);

                        randomActivity = activities[randomNumber];
                    }
                    else
                        Console.Write($"Ah got it!{userName}, your random activity is: {randomActivity}" +
                            $"! Is this ok or do you want to grab another activity? Keep/Redo: ");
                    Console.WriteLine();
                    cont = Console.ReadLine();
                    if (cont.ToLower() != "redo")
                    {
                        
                        return;
                    }
                }

            } while (cont.ToLower()=="redo");
                //}
               // else
                   // Console.WriteLine("You are exiting the program");


           
            
        }
    }
}
