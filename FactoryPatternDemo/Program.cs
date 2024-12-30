using System;

class Program
{
    static void Main(string[] args)
    {
        IAnimal dog = AnimalFactory.CreateAnimal("dog");
        dog.Speak();

        IAnimal cat = AnimalFactory.CreateAnimal("cat");
        cat.Speak();
    }
}