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
       public string Color { get; set; }
       public string Name {  get; set; }  
       public  int Age {  get; set; }   

     

        public void Jump ()
        {
            Console.WriteLine(Name + " is jumping "); 
        }
        public void Run () 
        {
            Console.WriteLine(Name + " is running");
        }
        public void Bark () 
        {
            Console.WriteLine(Name + "is playing");
        }
    }
    public class Dog : Animal
    {
        string Size;
        public Dog(string color_ =null, string name_ =null, int Age_ =0, string size_=null)
        {
            color_ = Color;
            name_ = Name;
            Age_ = Age;
            size_ = Size;
        }

        public void Eat()
        {
            Console.WriteLine(Name + "is eating");
        }
       public void makeSound()
        {
            Console.WriteLine( "The" + Name +  "is barking");
        }
    }

    public class Cat : Animal
    {
        String Eyecolor;
        public Cat(string color_ = null, string name_ = null, int Age_ =0, string eyecolor_ =null)
        {
            color_ = Color;
            name_ = Name;
            Age_ = Age;
            eyecolor_ = Eyecolor;
        }

        public void Cuddle()
        {
            Console.WriteLine("The " + Name + "is cuddling");
        }

        public void makeSound()
        {
            Console.WriteLine("The" + Name + "meowing");
        }
    }
    public class Bird : Animal
    {
        String Feathers;
        public Bird(string color_ = null, string name_ = null, int Age_ = 0, string feathers = null)
        {
            color_ = Color;
            name_ = Name;
            Age_ = Age;
            Feathers = feathers;
        }
        public void hunt() 
        {
            Console.WriteLine("The" + Name + " is hunting");
        }

        public void makeSound()
        {
            Console.WriteLine("The" + Name + " is whistling");
        }
    }
}
