using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {

        enum FavouriteColor
        {
            CZERWONY,
            ZIELONY,
            NIEBIESKI
        }


        class Person
        {
            public string Name { get; set; }
            public byte Age { get; set; }
            public FavouriteColor Color { get; set; }

            //konstruktor domyślny
            public Person()
            {
                Name = "Nieznane";
                Age = 0;
                Console.WriteLine("\nWywołano konstruktor domyslny");
            }

            //konstruktor parametryczny
            public Person(string name)
            {
                Name = name;
            }

            public Person (string name, byte age)
            {
                Name = name;
                Age = age;
                Console.WriteLine("\nKonstruktor z dwoma parametrami");
            }

            //najpierw wywołuje konstruktor dwuparametrowy,  bo jest <this> i odwołanie do niego
            public Person (string name, byte age, FavouriteColor color) :this(name, age)
            {
                Color = color;
                Console.WriteLine("\nKonstruktor z trzema parametrami");
            }


            //konstruktor kopiujący
            public Person(Person otherPerson) 
            {
                Name=otherPerson.Name;
                Age=otherPerson.Age;
                Color = otherPerson.Color;
                Console.WriteLine("\nWywołano konstruktor kopiujacy");
            }


            public void Info()
            {
                Console.WriteLine($"Imię: {Name}, wiek: {Age}, kolor: {Color}");
            }
        }


        static void Main(string[] args)
        {
            Person person = new Person();
            person.Info();

            Person person2 = new Person("Janusz");
            person2.Info();

            Person person3 = new Person("Eliza", 34);
            person3.Info();

            Person person4 = new Person("Paweł", 33, FavouriteColor.NIEBIESKI);
            person4.Info();

            Person person5 = new Person(person3);
            person5.Color = FavouriteColor.ZIELONY;
            person5.Info();
        }
    }
}
