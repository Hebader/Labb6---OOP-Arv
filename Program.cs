using System;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Labb6___OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class Animal
    {
       public string Breed { get; set; }
       public string Color { get; set; } 
       public  int Age {  get; set; }   

     

        public void Jump ()
        {
            Console.WriteLine(Breed + " is jumping "); 
        }
        public void Run () 
        {
            Console.WriteLine(Breed + " is running");
        }
        public void play () 
        {
            Console.WriteLine(Breed + "is playing");
        }
    }
    public class Dog : Animal
    {
        string Size;
        public Dog(string breed_ =null, string color_ = null, int Age_ =0, string size_=null)
        {
            breed_ = Breed;
            color_ = Color;
            Age_ = Age;
            size_ = Size;
        }

        public void Eat()
        {
            Console.WriteLine(Breed + "is eating");
        }
       public void makeSound()
        {
            Console.WriteLine( "The" + Breed +  "is barking");
        }
    }

    public class Cat : Animal
    {
        String Eyecolor;
        public Cat(string breed_, string color_ = null, int Age_ =0, string eyecolor_ =null)
        {
            color_ = Color;
            breed_ = Breed;
            Age_ = Age;
            eyecolor_ = Eyecolor;
        }

        public void Cuddle()
        {
            Console.WriteLine("The " + Breed + "is cuddling");
        }

        public void makeSound()
        {
            Console.WriteLine("The" + Breed + "meowing");
        }
    }
    public class Bird : Animal
    {
        String Feathers;
        public Bird(string breed_, string color_ = null, int Age_ = 0, string feathers = null)
        {
            color_ = Color;
            breed_ = Breed;
            Age_ = Age;
            Feathers = feathers;
        }
        public void hunt() 
        {
            Console.WriteLine("The" + Breed + " is hunting");
        }

        public void makeSound()
        {
            Console.WriteLine("The" + Breed + " is whistling");
        }
    }
}
