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
            Bird pelican = new Bird();
            pelican.name = "Pelican";
            Console.WriteLine($"The {pelican.name} is a {pelican.type}.\n" + $"it has feathers is a {pelican.hasFeathers} statement");
            Console.WriteLine($"it has {pelican.numberOfWings} wings");
            Console.WriteLine($"it eats {pelican.eats}");
            Console.WriteLine($"it breathes {pelican.breathes}");
            Console.WriteLine($"it can move is {pelican.canMove}");
            Console.WriteLine($"it has a beak is {pelican.hasBeak}");
            Console.WriteLine($"it has {pelican.numberOfLegs} legs");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile snake = new Reptile();
            snake.numberOfLegs = 0;
            snake.hasLungs = 2;
            snake.name = "Snake";

            Console.WriteLine($"The {snake.name} is a {snake.type}.\n" + $"it has scales is a {snake.hasScales} statement");
            Console.WriteLine($"it has {snake.hasLungs} lungs");
            Console.WriteLine($"it eats {snake.eats}");
            Console.WriteLine($"it breathes {snake.breathes}");
            Console.WriteLine($"it can move is {snake.canMove}");
            Console.WriteLine($"it is cold-blooded {snake.isColdBlooded}");
            Console.WriteLine($"it has {snake.numberOfLegs} legs");
        }
        
    }
}
