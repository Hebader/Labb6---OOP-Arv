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
        public Dog(string color_, string name_, int Age_, string size_)
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
                
    }

    public class Cat : Animal
    {
        String Eyecolor;
        public Cat(string color_, string name_, int Age_, string eyecolor_)
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
        public void Whistle() 
        {
            Console.WriteLine("The" + Name + " is whistling");
        }
    }
}
