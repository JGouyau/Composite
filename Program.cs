using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Person PetitEnfant1 = new Person("Louis");
            Person PetitEnfant2 = new Person("Timoté");
            Person PetitEnfant3 = new Person("Sebastine");
            Person Enfant1 = new Person("Loic");
            Person Enfant2 = new Person("Léa");
            Person Enfant3 = new Person("Cédric");
            Person Parent1 = new Person("Papa");
            Person Ancetre = new Person("Le vieux", new List<Person> { Parent1 });
            Parent1.AjouterDescendant(Enfant1);
            Parent1.AjouterDescendant(Enfant2);
            Parent1.AjouterDescendant(Enfant3);

            Enfant2.AjouterDescendant(PetitEnfant1);
            Enfant2.AjouterDescendant(PetitEnfant2);
            Enfant3.AjouterDescendant(PetitEnfant3);

            Console.WriteLine(PetitEnfant2.ToString());
            Console.WriteLine(Enfant2.ToString());

            Console.WriteLine("\n" + Ancetre.ToString());

            Console.ReadLine();
            

        }
    }
}
