using System;
namespace App
{
    class IntheritanceandOverriding
    {
        class Animal
        {
            String sound = "Some generic sound";
            public virtual string MakeSound()
            {
                return sound;
            }
        }

        class Dog : Animal
        {
            String sound = "Bark";
            public override string MakeSound()
            {
                return sound;

            }
        }
        class Cat : Animal
        {
            String sound = "Meow";
            public override string MakeSound()
            {
                return sound;

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