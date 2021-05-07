using System;
using FamilyTree.DI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.BL
{
    public class Date : IDate
    {
        private byte[,] dayCountOfMonth = new byte[12, 1]
        {
            //Январь-Февраль-Март-Апрель
            { 31 }, { 28 }, { 31 }, { 30 },
            //Май -  Июнь -  Июль - Август
            { 31 }, { 30 }, { 31 }, { 31 },
            //Сентябрь-Октябрь-Ноябрь-Декабрь
            { 30 }, { 31 }, { 30 }, { 31 }
        };


        public int MaxYear { get; set; } = 2100;
        public int MintYear { get; set; } = 1700;

        public int Day { get; private set; } = -1;
        public int Month { get; private set; } = -1;
        public int Year { get; private set; } = -1;

        public string FullDate { get { return ConvertDateToString(); } }


        public bool Exact { get; set; } = true;

        
        public void TrySetDate(int day, int month, int year, out bool result)
        {
            result = false;

            TrySetYear(year, out result);
            if (!result)
            {
                var argumentException = new ArgumentException ("Попытка установить год, несоответствующий" +
                                                               "заданным минимальным и максимальным границам", 
                                                               "year");
                throw argumentException;
                //Logger
            }

            TrySetMonth(month, out result);
            if (!result)
            {
                var argumentExceprion = new ArgumentException("Попытка установить некорретный месяц",
                                                              "month");

                throw argumentExceprion;
                //Logger
            }

            TrySetDay(day, out result);
            if (!result)
            {
                var argumentExceprion = new ArgumentException("Попытка установить некорретный день",
                                                              "day");

                throw argumentExceprion;
                //Logger
            }
        }
        public void TrySetDay(int day, out bool result)
        {
            result = false;

            if (Year != -1 && Year % 4 == 0 &&
                Month == 2 && day == 29)
            {
                Day = day;
                result = true;
            }

            else if (1 <= day && day <= 31)
            {
                if(Month != -1)
                {
                    if(day <= dayCountOfMonth[Month-1,0])
                    {
                        Day = day;
                        result = true;
                    }
                }
                else
                {
                    Day = day;
                    result = true;
                }
            }
        }
        public void TrySetMonth(int month, out bool result)
        {
            result = false;

            if (1 <= month && month <= 12)
            {
                Month = month;
                result = true;
                if (Day != -1)
                    TrySetDay(Day, out result);
            }
        }
        public void TrySetYear(int year, out bool result)
        {
            result = false;

            if (MintYear <= year && year <= MaxYear)
            {
                Year = year;
                result = true;
                if (Day != -1)
                    TrySetDay(Day, out result);
            }
        }


        private string ConvertDateToString()
        {
            string dateString = $"{ConvertDataToString(Day)}.{ConvertDataToString(Month)}.{ConvertDataToString(Year)}";

            if (!Exact)
                dateString += "?";

            return dateString;
        }
        private string ConvertDataToString(int data)
        {
            if (data == -1)
                return "?";
            else if (data < 10)
                return $"0{data}";
            else
                return $"{data}";
        }
    }
}
