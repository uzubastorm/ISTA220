using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_animals
{
    class Program
    {
        class Animal
        {
            public string name;
            public string Eat;
            public string poop;
            public string Speak;
            public void printbase()
            {
                Console.WriteLine("Hello, we are farm animals and my name is " + name);
                Console.WriteLine("i like to Eat" + Eat);          
                Console.WriteLine("i poop everywhere" + poop);
               
                
            }
        }


        class Pig : Animal
        {

            public void Speak()
            {
                Console.WriteLine("oink oink");
            }
            public void Eat()
            {
                Console.WriteLine("any and everything to eat");
            }
            public void poop()
            {
                Console.WriteLine("I HAVE TO POOP AHHHHHHH");
            }
            
           
        }


            class Cow : Animal
        {
            public void Speak()
            {
               Console.WriteLine("mooooooo");
            }    
                public void Eat()
            {
                Console.WriteLine("grass and any paper to eat");
            }
            public void poop()
            {
                Console.WriteLine("oh im pooping, eh?");
            }
        }
            class Horse : Animal
            {
                public void Speak()
                {
                    Console.WriteLine("neigh");
                }
                public void Eat()
            {
                Console.WriteLine("i'm a hey kind of person, get it HEY. yeah im so funny");
            }
            public void poop()
            {
                Console.WriteLine("I HAVE TO POOP EHHHHH AHHHHHH");
            }
        }

            class Chicken : Animal
            {
                public void Speak()
                {
                    Console.WriteLine("Cluck Cluck");
                }
                public void Eat()
            {
                Console.WriteLine("just gimme some seeds to eat");
            }
            public void poop()
            {
                Console.WriteLine("I HAVE TO POOP UUGGHHHHH");
            }

        }

        
        static void Main(string[] args)
        {
            Pig Bacon = new Pig();
            Bacon.name = "Bacon";
            Bacon.printbase();
            Bacon.Speak();
            Bacon.Eat();
            Bacon.poop();

            Console.WriteLine();

            Cow Henry = new Cow();
            Henry.name = "Henry";
            Henry.printbase();
            Henry.Speak();
            Henry.Eat();
            Henry.poop();

            Console.WriteLine();

            Horse Stephen = new Horse();
            Stephen.name = "Stephen";
            Stephen.printbase();
            Stephen.Speak();
            Stephen.Eat();
            Stephen.poop();


            Console.WriteLine();

            Chicken Rex = new Chicken();
            Rex.name = "Rex";
            Rex.printbase();
            Rex.Speak();
            Rex.Eat();
            Rex.poop();
        }
    }
}
