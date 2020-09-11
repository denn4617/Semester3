using System;

namespace OpgaverTilKlasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Dennis", "Kilic", 20);
            person1.fornavn = "Dunnis";
            person1.efternavn = "Kilic";
            person1.Alder = 20;

            Console.WriteLine(person1.fornavn + person1.efternavn + person1.Alder);
        }
    }
}