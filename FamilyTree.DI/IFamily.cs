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
        /// <returns> Список IPerson, являющиеся бабушками вызываемому объекту IPerson.  </returns>
        List<IPerson> GrandMothers();

        /// <summary>
        /// Формирует и возвращает список дедушек.
        /// </summary>
        /// <returns> Список IPerson, являющиеся дедушками вызываемому объекту IPerson.  </returns>
        List<IPerson> GrandFathers();

        /// <summary>
        /// Формирует и возвращает список бабушек и дедушек.
        /// </summary>
        /// <returns> Список IPerson, являющиеся бабушками и дедушками вызываемому объекту IPerson.  </returns>
        List<IPerson> GrandParents();


        /// <summary>
        /// Формирует и возвращает список дядь.
        /// </summary>
        /// <returns> Список IPerson, являющиеся дядями вызываемому объекту IPerson.  </returns>
        List<IPerson> Uncles();

        /// <summary>
        /// Формирует и возвращает список теть.
        /// </summary>
        /// <returns> Список IPerson, являющиеся тетями вызываемому объекту IPerson.  </returns>
        List<IPerson> Aunts();

        #endregion


        #region Ровесники родственники

        /// <summary>
        /// Формирует и возвращает список братьев.
        /// </summary>
        /// <returns> Список IPerson, являющиеся братьями вызываемому объекту IPerson.  </returns>
        List<IPerson> Brothers();

        /// <summary>
        /// Формирует и возвращает список сестер.
        /// </summary>
        /// <returns> Список IPerson, являющиеся сестрами вызываемому объекту IPerson.  </returns>
        List<IPerson> Sisters();


        /// <summary>
        /// Формирует и возвращает список двоюродных братьев и сестер.
        /// </summary>
        /// <returns> Список IPerson, являющиеся двоюродными братьями и сестрами вызываемому объекту IPerson.  </returns>
        List<IPerson> Cousins();

        /// <summary>
        /// Формирует и возвращает список двоюродных братьев.
        /// </summary>
        /// <returns> Список IPerson, являющиеся двоюродными братьями вызываемому объекту IPerson.  </returns>
        List<IPerson> CousinsBrothers();

        /// <summary>
        /// Формирует и возвращает список двоюродных сестер.
        /// </summary>
        /// <returns> Список IPerson, являющиеся двоюродными сестрами вызываемому объекту IPerson.  </returns>
        List<IPerson> CousinsSisters();

        #endregion


        #region Младшие родственники

        /// <summary>
        /// Формирует и возвращает список детей.
        /// </summary>
        /// <returns> Список IPerson, являющиеся детьми вызываемому объекту IPerson.  </returns>
        List<IPerson> Children();

        /// <summary>
        /// Формирует и возвращает список дочерей.
        /// </summary>
        /// <returns> Список IPerson, являющиеся дочерьми вызываемому объекту IPerson.  </returns>
        List<IPerson> Daughters();

        /// <summary>
        /// Формирует и возвращает список сыновей.
        /// </summary>
        /// <returns> Список IPerson, являющиеся сыновьями вызываемому объекту IPerson.  </returns>
        List<IPerson> Sons();


        /// <summary>
        /// Формирует и возвращает список племянников и племянниц.
        /// </summary>
        /// <returns> Список IPerson, являющиеся племянниками и племянницами вызываемому объекту IPerson.  </returns>
        List<IPerson> NephewsAndNieces();

        /// <summary>
        /// Формирует и возвращает список племянников.
        /// </summary>
        /// <returns> Список IPerson, являющиеся племянниками вызываемому объекту IPerson.  </returns>
        List<IPerson> Nephews();

        /// <summary>
        /// Формирует и возвращает список племянниц.
        /// </summary>
        /// <returns> Список IPerson, являющиеся племянницами вызываемому объекту IPerson.  </returns>
        List<IPerson> Nieces();

        #endregion
    }
}
