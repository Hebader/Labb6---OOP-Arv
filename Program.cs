﻿using System;
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

    public class Animal // skapar klassen Animal
    {
        //properties
       public string Breed { get; set; } //"get/set" för att kunna användas i andra klasser
       public string Color { get; set; } 
       public  int Age {  get; set; }   

     

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
        public Dog(string breed_ =null, string color_ = null, int Age_ =0, string size_=null)
        {
            breed_ = Breed;
            color_ = Color;
            Age_ = Age;
            size_ = Size;
        }

        public void Eat()
        {
            Console.WriteLine("The dog is eating");
        }
       public void makeSound()
        {
            Console.WriteLine( "The dog is barking");
        }
    }

    public class Cat:Animal
    {
        String Eyecolor;
        public Cat(string breed_ =null, string color_ = null, int Age_ =0, string eyecolor_ =null)
        {
            color_ = Color;
            breed_ = Breed;
            Age_ = Age;
            eyecolor_ = Eyecolor;
        }

        public void Cuddle()
        {
            Console.WriteLine("The cat is cuddling");
        }

        public void makeSound()
        {
            Console.WriteLine("The cat is meowing");
        }
    }
    public class Bird : Animal
    {
        String Feathers;
        public Bird(string breed_=null, string color_ = null, int Age_ = 0, string feathers = null)
        {
            
            breed_ = Breed;
            color_ = Color;
            Age_ = Age;
            Feathers = feathers;
        }
        public void hunt() 
        {
            Console.WriteLine("The bird is hunting");
        }

        public void makeSound()
        {
            Console.WriteLine("The bird is whistling");
        }
    }

    public class Bulldog: Dog
    {
        string Weight;

        public Bulldog (string weight)
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

        string Lenght;

        public Chihuahua (string lenght)
        {
            lenght = Lenght;
        }

        public void rest()
        {
            Console.WriteLine("The dog is resting");
        }


            
    }


}
