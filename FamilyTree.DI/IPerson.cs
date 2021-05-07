using System.Collections.Generic;
namespace FamilyTree.DI
{
    public interface IPerson
    {
        /// <summary>
        /// Имя.
        /// </summary>
        string Name { get; set; }
        
        /// <summary>
        /// Фамилия.
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        string Patronymic { get; set; }

        /// <summary>
        /// Возраст.
        /// </summary>
        int Age { get; set; }


        /// <summary>
        /// Путь по которому находятся данные, связанные с человеком.
        /// </summary>
        string DataPath { get; set; }


        /// <summary>
        /// Дата рождения.
        /// </summary>
        IDate Birth { get; set; }

        /// <summary>
        /// Дата смерти.
        /// </summary>
        IDate Death { get; set; }


        /// <summary>
        /// Семья.
        /// </summary>
        IFamily Family { get; }


        /// <summary>
        /// Возвращает фамилию, имя и отчество.
        /// </summary>
        /// /// <returns> Строку формата: {Фамидия} {Имя} {Отчество}. </returns>
        string FullName();

        /// <summary>
        /// Возвращает годы жизни человека.
        /// </summary>
        /// <returns> Строку формата: {дата рождения} - {дата смерти}. </returns>
        string YearsOfLife();
    }
}
