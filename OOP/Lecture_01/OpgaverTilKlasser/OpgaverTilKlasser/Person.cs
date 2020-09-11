using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaverTilKlasser
{
    class Person
    {
        public string fornavn;
        public string efternavn;
        int alder;

        public Person(string fornavnNy, string efternavnNy, int alderNy)
        {
            this.fornavn = fornavnNy;
            this.efternavn = efternavnNy;
            this.alder = alderNy;
        }

        public int Alder
        {
            get { return alder; }
            set
            {
                if (value == 20)
                {
                    alder = value;
                }
                //else
                //{
                //    alder = 11;
                //}
            }
        }
    }
}