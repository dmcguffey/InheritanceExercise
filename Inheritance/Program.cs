using System;
using System.Threading;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class


            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird Cardinal = new Bird()
            {
                legs = 2,
                isAlive = true,
                noise = "cheep cheep",
                wings = "small and red",
                beak = "small",
                flies = true,
                feathers = "bright red"

            };
            if (Cardinal.isAlive == true)
            {
                Console.WriteLine($"Oh look! It's a {Cardinal}! I can tell by the {Cardinal.wings} wings and {Cardinal.feathers} feathers!");
                Console.WriteLine($"Their {Cardinal.legs} legs are short and skinny to help them fly easier!");
                Cardinal.makeNoise();
            }


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile Snake = new Reptile()
            {
                legs = 0,
                isAlive = true,
                noise = "Hissss",
                scales = "brown and white",
                isVenomous = false,
                tail = "the whole creepy body",
                coldBlood = true
            };
            if (Snake.isAlive == true)
            {
                Snake.makeNoise();
                Console.WriteLine($"Yikes! I heard a snake! Where is he??");
                Console.ReadLine();
                Console.WriteLine($"I see it! Oh my gosh I can see its {Snake.scales} scales and {Snake.tail}!");
                if (Snake.coldBlood == true)
                {
                    Console.WriteLine($"Did you know snakes are cold blooded? That means their body temperature can change!");
                }

                if (Snake.isVenomous == false)
                {
                    Console.WriteLine($"Oh thank goodness! It's not a venomous snake.");
                }
            }
            }
        }
    }


