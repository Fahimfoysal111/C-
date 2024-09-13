using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17_18_GenericApproch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal { Name = "Cow", Age = 10, Gendertype = Gender.Male, type = AnimalType.Omnivore };// Creating an Animal object "cow" with initialized properties.
            // Creating a GenericAnimal instance and printing generic behavior for "cow".
            GenericAnimal <Animal> animal = new GenericAnimal<Animal>();
            Console.WriteLine(animal.GenericBehaviour(cow));
            Animal ox = new Animal { Name = "ox", Age = 10, Gendertype = Gender.Male, type = AnimalType.Carnivore };
            TypespecificAnimal<Animal> OX = new TypespecificAnimal<Animal>();
            Console.WriteLine(OX.Gettypespecificbehaviour(ox));

        }
    }
}
