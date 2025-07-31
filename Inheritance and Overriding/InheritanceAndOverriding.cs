using System;
namespace App
{
    class IntheritanceandOverriding
    {
        class Animal
        {
            String sentence = "Some generic sound";
            public virtual string MakeSound()
            {
                return sentence;
            }
        }

        class Dog : Animal
        {
            String sentence = "Bark";
            public override string MakeSound()
            {
                return sentence;

            }
        }
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Console.WriteLine($"{dog.MakeSound()}");

        }
    }
}