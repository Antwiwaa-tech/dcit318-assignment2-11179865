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
        class Cat : Animal
        {
            String sentence = "Meow";
            public override string MakeSound()
            {
                return sentence;

            }
        }
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            Console.WriteLine(animal.MakeSound()); 
            Console.WriteLine(dog.MakeSound());    
            Console.WriteLine(cat.MakeSound());
        }
    }
}