using System;
namespace InterfaceImplementation
{
    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move() {
            Console.WriteLine("Car is moving");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");

        }
    }

public class Program
    {
        public static void Main(String[] args)
        {
            IMovable car = new Car();
            car.Move();

            IMovable bike = new Bicycle();
            bike.Move();


        }
    }
   
}