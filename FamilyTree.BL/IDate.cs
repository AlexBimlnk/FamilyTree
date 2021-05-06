using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.BL
{
    public interface IDate
    {
        /// <summary>
        /// Минимальная граница лет.
        /// </summary>
        int MaxYear { get; set; }
        /// <summary>
        /// Максимальная граница лет.
        /// </summary>
        int MintYear { get; set; }

        /// <summary>
        /// День.
        /// </summary>
        int Day { get; }
        /// <summary>
        /// Месяц.
        /// </summary>
        int Month { get; }
        /// <summary>
        /// Год.
        /// </summary>
        int Year { get; }

        /// <summary>
        /// Возращает дату в виде строки.
        /// </summary>
        string FullDate { get; }


        /// <summary>
        /// Дополнительная информация, связанная с этой датой.
        /// </summary>
        string Infomation { get; set; }


        /// <summary>
        /// Указывает, является ли дата конкретной.
        /// </summary>
        bool Exact { get; set; }


        /// <summary>
        /// Устанавливает полную дату. Возвращает результат операции.
        /// </summary>
        /// <param name="day"> День, который нужно установить. </param>
        /// <param name="month"> Месяц, который нужно установить. </param>
        /// <param name="year"> Год, который нужно установить. </param>
        /// <exception cref="ArgumentException"> Генерирует ошибку при неправильных входных данных. </exception>
        void TrySetDate(int day, int month, int year, out bool result);

        /// <summary>
        /// Устанавливает день. Возвращает результат операции.
        /// </summary>
        /// <param name="day"> День, который нужно установить. </param>
        /// <param name="result"> Реузльтат выполнения: True - установлено корректно. False - ошибка. </param>
        void TrySetDay(int day, out bool result);

        /// <summary>
        /// Устанавливает месяц. Возвращает результат операции.
        /// </summary>
        /// <param name="month"> Месяц, который нужно установить. </param>
        /// <param name="result"> Реузльтат выполнения: True - установлено корректно. False - ошибка. </param>
        void TrySetMonth(int month, out bool result);

        /// <summary>
        /// Устанавливает год. Возвращает результат операции.
        /// </summary>
        /// <param name="_month"> Год, который нужно установить. </param>
        /// <param name="result"> Реузльтат выполнения: True - установлено корректно. False - ошибка. </param>
        void TrySetYear(int year, out bool result);
    }
}
