using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.BL
{
    public class Person 
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Patronymic { get; private set; }

        public string FullName
        {
            get
            {
                return $"{LastName} {Name} {Patronymic}";
            }
        }



        //public Person(string name, string lastName, string patronymic, int age, )

    }
}
