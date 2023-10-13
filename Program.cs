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
        string Color;
        string Name;
        string Age;

        public Animal(string color_, string name_, string Age_)
        {
            color_ = Color;
            name_ = Name;
            Age_ = Age;
        }

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
}