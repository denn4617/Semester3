using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaverTilKlasser
{
    class PersonPrinter
    {
        public PersonPrinter(string Fornavn, string Efternavn, int Alder)
        {
            Console.WriteLine("{0} {1}, {2}", Fornavn, Efternavn, Alder);
        }
    }
}