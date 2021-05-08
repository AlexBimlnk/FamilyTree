using System.Collections.Generic;
namespace FamilyTree.DI
{
    public interface IFamily
    {
        /// <summary>
        /// Мать.
        /// </summary>
        IPerson Mother { get; set; }

        /// <summary>
        /// Отец.
        /// </summary>
        IPerson Father { get; set; }

        /// <summary>
        /// Брачный партнер.
        /// </summary>
        IPerson MarriagePartner { get; set; }


        #region Старшие родственники

        /// <summary>
        /// Формирует и возвращает список бабушек.
        /// </summary>
        /// <returns> Список IPerson, являющийся бабушками вызываемому объекту IPerson.  </returns>
        List<IPerson> GrandMothers();

        /// <summary>
        /// Формирует и возвращает список дедушек.
        /// </summary>
        /// <returns> Список IPerson, являющийся дедушками вызываемому объекту IPerson.  </returns>
        List<IPerson> GrandFathers();

        /// <summary>
        /// Формирует и возвращает список бабушек и дедушек.
        /// </summary>
        /// <returns> Список IPerson, являющийся бабушками и дедушками вызываемому объекту IPerson.  </returns>
        List<IPerson> GrandParents();


        /// <summary>
        /// Формирует и возвращает список дядь.
        /// </summary>
        /// <returns> Список IPerson, являющийся дядями вызываемому объекту IPerson.  </returns>
        List<IPerson> Uncles();

        /// <summary>
        /// Формирует и возвращает список теть.
        /// </summary>
        /// <returns> Список IPerson, являющийся тетями вызываемому объекту IPerson.  </returns>
        List<IPerson> Aunts();

        #endregion


        #region Ровесники родственники

        /// <summary>
        /// Формирует и возвращает список братьев.
        /// </summary>
        /// <returns> Список IPerson, являющийся братьями вызываемому объекту IPerson.  </returns>
        List<IPerson> Brothers();

        /// <summary>
        /// Формирует и возвращает список сестер.
        /// </summary>
        /// <returns> Список IPerson, являющийся сестрами вызываемому объекту IPerson.  </returns>
        List<IPerson> Sisters();


        /// <summary>
        /// Формирует и возвращает список двоюродных братьев и сестер.
        /// </summary>
        /// <returns> Список IPerson, являющийся двоюродными братьями и сестрами вызываемому объекту IPerson.  </returns>
        List<IPerson> Cousins();

        /// <summary>
        /// Формирует и возвращает список двоюродных братьев.
        /// </summary>
        /// <returns> Список IPerson, являющийся двоюродными братьями вызываемому объекту IPerson.  </returns>
        List<IPerson> CousinsBrothers();

        /// <summary>
        /// Формирует и возвращает список двоюродных сестер.
        /// </summary>
        /// <returns> Список IPerson, являющийся двоюродными сестрами вызываемому объекту IPerson.  </returns>
        List<IPerson> CousinsSisters();

        #endregion


        #region Младшие родственники

        /// <summary>
        /// Формирует и возвращает список детей.
        /// </summary>
        /// <returns> Список IPerson, являющийся детьми вызываемому объекту IPerson.  </returns>
        List<IPerson> Children();

        /// <summary>
        /// Формирует и возвращает список дочерей.
        /// </summary>
        /// <returns> Список IPerson, являющийся дочерьми вызываемому объекту IPerson.  </returns>
        List<IPerson> Daughters();

        /// <summary>
        /// Формирует и возвращает список сыновей.
        /// </summary>
        /// <returns> Список IPerson, являющийся сыновьями вызываемому объекту IPerson.  </returns>
        List<IPerson> Sons();


        /// <summary>
        /// Формирует и возвращает список племянников и племянниц.
        /// </summary>
        /// <returns> Список IPerson, являющийся племянниками и племянницами вызываемому объекту IPerson.  </returns>
        List<IPerson> NephewsAndNieces();

        /// <summary>
        /// Формирует и возвращает список племянников.
        /// </summary>
        /// <returns> Список IPerson, являющийся племянниками вызываемому объекту IPerson.  </returns>
        List<IPerson> Nephews();

        /// <summary>
        /// Формирует и возвращает список племянниц.
        /// </summary>
        /// <returns> Список IPerson, являющийся племянницами вызываемому объекту IPerson.  </returns>
        List<IPerson> Nieces();

        #endregion


        /// <summary>
        /// Добавить ребенка.
        /// </summary>
        /// <param name="child"> Ребенок. </param>
        void AddChild(IPerson child);

        /// <summary>
        /// Добавить брата.
        /// </summary>
        /// <param name="brother"> Брат. </param>
        void AddBrother(IPerson brother);

        /// <summary>
        /// Добавить сестру.
        /// </summary>
        /// <param name="sister"> Сестра. </param>
        void AddSister(IPerson sister);
    }
}
