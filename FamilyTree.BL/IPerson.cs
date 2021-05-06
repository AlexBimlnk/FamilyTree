using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.BL
{
    public interface IPerson
    {
        /// <summary>
        /// Имя.
        /// </summary>
        string Name { get; }
        
        /// <summary>
        /// Фамилия.
        /// </summary>
        string LastName { get; }

        /// <summary>
        /// Отчество.
        /// </summary>
        string Patronymic { get; }

        /// <summary>
        /// Возвращает фамилию, имя и отчество.
        /// </summary>
        string FullName { get; }

        /// <summary>
        /// Возраст.
        /// </summary>
        int Age { get; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        Date Birth { get; }

        /// <summary>
        /// Дата смерти.
        /// </summary>
        Date Death { get; }
    }
}
