using System;
namespace PolymorphismOOP;
public class Program
{
    public static void Main(string[] args)
    {
        IAnimal bird = new Bird();
        IAnimal fish = new Fish();
        bird.Move();
        bird.Eat();
        bird.Sleep();
        fish.Move();
        fish.Eat();
        fish.Sleep();
    }
}
