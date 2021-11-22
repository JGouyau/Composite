using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Person
    {
        List<Person> DescendantDirect { get; set; }

        string Name { get; set; }

        public Person(string name, List<Person> descendant)
        {
            Name = name;
            DescendantDirect = descendant;
        }

        public Person(string name)
        {
            Name = name;
            DescendantDirect = new List<Person>();
        }

        public void AjouterDescendant(Person person)
        {
            DescendantDirect.Add(person);
        }

        public override string ToString()
        {
            string descendantString;
            if (DescendantDirect.Count > 0)
            {
                descendantString = $"Les descendants direct de {Name} sont : " + String.Join(", ", DescendantDirect.Select(p => p.Name));

                foreach (Person p in DescendantDirect)
                {
                    descendantString += "\n" + p.ToString();
                }
            }
            else
            {
                descendantString = $"{Name} n'a pas de descendant direct";
            }
            return descendantString;
        }
    }
}
