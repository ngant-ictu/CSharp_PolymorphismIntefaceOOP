using System;

namespace PolymorphismOOP
{
    public class Bird : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Bird is flying");
        }

        public void Eat()
        {
            Console.WriteLine("Bird is eating");
        }
        public void Sleep()
        {
            Console.WriteLine("Bird is sleeping");
        }
    }
}

