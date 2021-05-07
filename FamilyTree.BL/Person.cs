using System;
using System.Collections.Generic;
using FamilyTree.DI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.BL
{
    public class Person : IPerson
    {

        protected int _age = -1;
        protected IFamily family;

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int Age
        {
            get { return _age; }
            set { if (value > 0) _age = value; }
        }

        public IDate Birth { get; set; }
        public IDate Death { get; set; }

        public string DataPath { get; set; }


        public IFamily Family => family;


        public Person() { }

        public Person(string name, string lastName, string patronymic,
                      int age, string dateBirth, string dateDeath)
        {
            bool result;

            Name = name;
            LastName = lastName;
            Patronymic = patronymic;
            Age = age;

            int[] buffer = Array.ConvertAll(dateBirth.Split('.'), x => int.Parse(x));

            Birth = new Date();
            Birth.TrySetDate(buffer[0], buffer[1], buffer[2], out result);

            buffer = Array.ConvertAll(dateDeath.Split('.'), x => int.Parse(x));

            Death = new Date();
            Death.TrySetDate(buffer[0], buffer[1], buffer[2], out result);
        }


        public virtual string FullName()
        {
            return $"{LastName} {Name} {Patronymic}";
        }

        public string YearsOfLife()
        {
            return $"{Birth.FullDate} - {Death.FullDate}";
        }
    }
}
