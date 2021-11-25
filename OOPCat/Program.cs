using System;

namespace OOPCat
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hungryness;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungryness = 0;
                Console.WriteLine($"The cat {name} with {color} color has been created.");
            }
            public string Name
            {
                get { return name; }
            }

            public string Color
            {
                get { return color; }
            }
            public double Hungryness
            {
                get { return hungryness; }
            }

            public void Sleep()
            {
                Console.WriteLine("Cat is sleeping.");
                hungryness += 0.2; //happiness = happiness + 0.2
            }

            public void Meow()
            {
                Console.WriteLine("Meow-Meow");
            }


        }
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Kass", "Blue");
            //myDog.happiness = 10;
            //myDog.name = "Good boy"

            while (myCat.Hungryness != 1)
            {
                myCat.Sleep();
            }

            myCat.Meow();

            Console.WriteLine($"Name: {myCat.Name}");
            Console.WriteLine($"Cats color is {myCat.Color}");
        }
    }
}
