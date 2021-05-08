using System;
using FamilyTree.DI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.BL
{
    public class Man : Person
    {
        public Man()
        {
            Gender = Genders.Man;
        }

        public Man(string name, string lastName,
                    string patronymic, int age, string dateBirth, string dateDeath)
            : base(name, lastName, patronymic, age, dateBirth, dateDeath)
        {
            Gender = Genders.Man;
        }
    }
}
