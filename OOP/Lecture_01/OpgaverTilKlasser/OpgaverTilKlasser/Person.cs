using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaverTilKlasser
{
    class Person
    {
        public string fornavn;
        public string efternavn;
        int _alder;
        public Person Far;
        public Person Mor;

        

        public Person(string fornavnNy, string efternavnNy, int alderNy)
        {
            this.fornavn = fornavnNy;
            this.efternavn = efternavnNy;
            _alder = alderNy;
        }

        public int Alder
        {
            get { return _alder; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                else
                {
                    _alder = value;
                }
            }
        }
    }
}