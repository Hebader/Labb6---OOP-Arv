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
           Cat cat = new Cat ();
           cat.makeSound();
           Dog dog = new Dog ();
           dog.makeSound();
           Bird bird = new Bird();
           bird.makeSound();
        }
    }

    public abstract class Animal // skapar klassen Animal
    {
        //properties
       public string Breed { get; set; } //"get/set" för att kunna användas i andra klasser
       public string Color { get; set; } 
       public  int Age { get; set; }   


        public Animal (string breed = null, string color =null, int age = 0)
        {
            Breed = breed;
            Color = color;
            Age = age;
        }

     

        public void Jump () // Skapar en metod
        {
            Console.WriteLine("Jumping"); //Utskrift
        }
        public void Run () 
        {
            Console.WriteLine("Running");
        }
        public void play () 
        {
            Console.WriteLine("playing");
        }
    }
    public class Dog : Animal //klassen Dog ärver allt från klassen Animal
    {
        string Size;
        public Dog(string breed_=null, string color_ = null, int age_ =0, string size_=null)
            :base (breed_,color_,age_)
        {
        
            size_ = Size;
        }

        public void Eat()
        {
            Console.WriteLine("The dog is eating.");
        }
       public void makeSound()
        {
            Console.WriteLine( "The dog is barking.");
        }
    }

    public class Cat:Animal
    {
        String Eyecolor {get; }
        public Cat(string breed_ =null, string color_ = null, int age_ =0, string eyecolor_ =null)
            :base (breed_,color_, age_)
        {
            
            eyecolor_ = Eyecolor;
        }

        public void Cuddle()
        {
            Console.WriteLine("The cat is cuddling");
        }

        public void makeSound()
        {
            Console.WriteLine("The cat is meowing.");
        }
    }
    public class Bird : Animal
    {
        String Feathers{ get; }
        public Bird(string breed_=null, string color_ = null, int age_ = 0, string feathers = null)
            :base (breed_ ,color_, age_) 
        {
            
     
            Feathers = feathers;
        }
        public void hunt() 
        {
            Console.WriteLine("The bird is hunting");
        }

        public void makeSound()
        {
            Console.WriteLine("The bird is whistling.");
        }
    }

    public class Bulldog: Dog // Arv i två nivåer
    {
        int Weight { get; }
        
        public Bulldog (string breed_ = null, string color_ = null, int age_ = 0, string size_ = null, int weight = 0)
            : base(breed_, color_, age_, size_) // ärver data från "Dog"
        {
            
            Weight = weight;
        }

        public void roll()
        {
            Console.WriteLine("The dog is rolling");
        }
    }
    public class Chihuahua: Dog
    {

        int Lenght;

        public Chihuahua(string breed_ = null, string color_ = null, int age_ = 0, string size_ = null, int lenght= 0)
            :base (breed_,color_,age_,size_)        
        {
            Lenght = lenght;

        }


        public void rest()
        {
            Console.WriteLine("The dog is resting");
        }


            
    }


}
