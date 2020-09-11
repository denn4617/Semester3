using System;

namespace OpgaverTilKlasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Person far = new Person("", "", 46);
            Person mor = new Person("", "", 38);
            Person person1 = new Person("Dennis", "Kilic", 20);
            person1.fornavn = "Dunnis";
            person1.efternavn = "Kilic";
            person1.Alder = 20;
            person1.Mor = mor;

            mor.fornavn = "Mathilde";

            Console.WriteLine($"{person1.fornavn} {person1.efternavn}, {person1.Alder}");
        }
    }
}