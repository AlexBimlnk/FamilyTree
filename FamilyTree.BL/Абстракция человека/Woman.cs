using System;
using FamilyTree.DI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.BL
{
    public class Woman : Person
    {
        /// <summary>
        /// Девичья фамилия.
        /// </summary>
        public string MaidenName { get; set; } = "";


        public Woman()
        {
            Gender = Genders.Woman;
        }

        public Woman(string name, string maidenName, string lastName, 
                    string patronymic, int age, string dateBirth, string dateDeath) 
            : base (name, lastName, patronymic, age, dateBirth, dateDeath)
        {
            Gender = Genders.Woman;

            MaidenName = maidenName;
        }


        public override string FullName()
        {
            if(MaidenName != "")
                return $"{LastName} ({MaidenName}) {Name} {Patronymic}";
            else
                return $"{LastName} {Name} {Patronymic}";
        }
    }
}
