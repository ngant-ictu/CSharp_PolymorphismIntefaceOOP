using System;

namespace PolymorphismOOP {
    public class Fish : IAnimal {
        public void Move() {
            Console.WriteLine("Fish is swimming");
        }

        public void Eat() {
            Console.WriteLine("Fish is eating");
        }

        public void Sleep() {
            Console.WriteLine("Fish is sleeping");
        }
    }
}
