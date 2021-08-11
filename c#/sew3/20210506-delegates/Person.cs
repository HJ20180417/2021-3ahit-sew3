using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210506_delegates
{
    class Person
    {
        public string Name
        {
            get; set;
        }
        public Person(string name)
        {
            Name = name;
        }
        public string ZumGeburtstag(string name)
        {
            return "Alles gute zum Geburtstag " + name;
        }
        public string ZumMuttertag(string name)
        {
            return "Alles gute zum Muttertag wünscht dir " + name;
        }

    }
}
