using System;
using System.Globalization;

namespace Pets
{
    interface IFeedable
    {
        void Feed(string food);
    }
    abstract class Animal
    {
        string name;
        int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public abstract void MakeSound();

        class Pets : Animal, IFeedable
        {
            string name;
            int age;
            string species;
            string owner;

            public string Name { get { return name; } set { name = value; } }
            public int Age { get { return age; } set { age = value; } }
            public string Species { get { return species; } set { species = value; } }
            public string Owner { get { return owner; } set { owner = "Max Müller"; } }
            public Pets(string name, int age, string species)
            {
                this.name = name;
                this.age = age;
                this.species = species;
            }
            public Pets(string name, int age, string species, string owner) : this(name, age, species)
            {
                this.owner = owner;
            }
            public override void MakeSound()
            {
                Console.WriteLine("The pet makes a sound...");
            }
            public void Feed(string food)
            {
                Console.WriteLine($"{name} is eating {food}.");
            }
            public override string ToString()
            {
                return $"Name: {name}, Age: {age}, Species: {species}, Owner: {owner}";
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Pets myPet1 = new Pets("Bello", 3, "Dog");
                Pets myPet2 = new Pets("Miezi", 2, "Cat", "Anna");
                Console.WriteLine($"Name: {myPet1.Name}, Age: {myPet1.Age}, Species: {myPet1.Species}, Owner: {myPet1.Owner}");
                Console.WriteLine($"Name: {myPet2.Name}, Age: {myPet2.Age}, Species: {myPet2.Species}, Owner: {myPet2.Owner}");

                Pets myPet = new Pets("Rocky", 4, "Dog", "Tom");
                myPet.MakeSound();
                myPet.Feed("dog food");

                Console.WriteLine(myPet);
                Console.ReadKey();
            }
        }
    }
}
