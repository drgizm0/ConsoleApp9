// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {        
           Snake snake = new Snake();
            Cow cow = new Cow();

            snake.Speak();
            cow.Speak();

            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }
    class Snake: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The snake goes *sssss*");
        }
    }
    class Cow : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cow goes *mooo*");
        }
    }
}
