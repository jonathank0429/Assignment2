using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på ett sträng argument

        public class Factory
        {
            public string type_of_factory { get; set; }
            public Factory(string factorytype)
            {
                type_of_factory = factorytype;
            }

            public class Animal
            {
                public string name_of_animal { get; set; }
            }

            public List<Animal> RegistedAnimals = new List<Animal>();


            public void CreateAnimal(string name)
            {
                Animal animal = new Animal();
                animal.name_of_animal = name;
                RegistedAnimals.Add(animal);
            }

        }
        
        public void Run()
        {
            Factory hundfactory = new Factory("hund");
            hundfactory.CreateAnimal("Rocky");
            hundfactory.CreateAnimal("Albert");

            Factory kattfactory = new Factory("Katt");
            kattfactory.CreateAnimal("Mia");
            kattfactory.CreateAnimal("Vilbur");

            foreach(Factory.Animal animal in hundfactory.RegistedAnimals)
            {
                Console.WriteLine(animal.name_of_animal);
            }

            foreach (Factory.Animal animal in kattfactory.RegistedAnimals)
            {
                Console.WriteLine(animal.name_of_animal);
            }



        }
    }
}
