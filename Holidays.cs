using System;

namespace Synercoding.Dates
{
    public static class Holidays
    {
        /// <summary>
        /// New years day
        /// </summary>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime NewYearsDay(int year)
        {
            return new DateTime(year, 1, 1);
        }

        /// <summary>
        /// New years day
        /// </summary>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime NewYearsEve(int year)
        {
            return new DateTime(year, 12, 31);
        }

        /// <summary>
        /// Saint Martin's Day
        /// </summary>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime SaintMartinsDay(int year)
        {
            return new DateTime(year, 11, 11);
        }

        /// <summary>
        /// Saint Nicolas Day
        /// </summary>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime SaintNicolasDay(int year)
        {
            return new DateTime(year, 12, 5);
        }

        /// <summary>
        /// Christmas
        /// </summary>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime Christmas(int year)
        {
            return new DateTime(year, 12, 25);
        }

        /// <summary>
        /// Three kings
        /// </summary>
        /// <remarks>
        /// Dutch: Driekoningen
        /// </remarks>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime Epiphany(int year)
        {
            return new DateTime(year, 1, 6);
        }

        /// <summary>
        /// Valentine
        /// </summary>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime Valentine(int year)
        {
            return new DateTime(year, 2, 14);
        }

        /// <summary>
        /// Calculate easter using the anonymous Gregorian algorithm
        /// </summary>
        /// <remarks>
        /// Dutch: Pasen
        /// </remarks>
        /// <param name="year">The year to calculate easter for</param>
        /// <returns>The date easter falls on</returns>
        public static DateTime Easter(int year)
        {
            var a = year % 19;
            var b = Math.Floor(year / 100d);
            var c = year % 100;
            var d = Math.Floor(b / 4);
            var e = b % 4;
            var f = Math.Floor((b + 8) / 25);
            var g = Math.Floor((b - f + 1) / 3);
            var h = (19 * a + b - d - g + 15) % 30;
            var i = Math.Floor(c / 4d);
            var k = c % 4;
            var l = (32 + 2 * e + 2 * i - h - k) % 7;
            var m = Math.Floor((a + 11 * h + 22 * l) / 451);

            var month = (int)Math.Floor((h + l - 7 * m + 114) / 31);
            var day = (int)(((h + l - 7 * m + 114) % 31) + 1);

            return new DateTime(year, month, day);
        }

        /// <summary>
        /// Labour Day
        /// </summary>
        /// <remarks>
        /// Dutch: Dag van de arbeid
        /// </remarks>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime LabourDay(int year)
        {
            return new DateTime(year, 5, 1);
        }

        /// <summary>
        /// Good Friday
        /// </summary>
        /// <remarks>
        /// Dutch: Goede vrijdag
        /// </remarks>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime GoodFriday(int year)
        {
            return Easter(year).AddDays(-2);
        }

        /// <summary>
        /// Carnival
        /// </summary>
        /// <remarks>
        /// Dutch: Carnaval
        /// </remarks>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime Carnival(int year)
        {
            return Easter(year).AddDays(-49);
        }

        /// <summary>
        /// Ascension Day
        /// </summary>
        /// <remarks>
        /// Dutch: Hemelvaartsdag
        /// </remarks>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime AscensionDay(int year)
        {
            return Easter(year).AddDays(39);
        }

        /// <summary>
        /// Pentecost
        /// </summary>
        /// <remarks>
        /// Dutch: Pinksteren
        /// </remarks>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime Pentecost(int year)
        {
            return Easter(year).AddDays(49);
        }

        /// <summary>
        /// Summer time
        /// </summary>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The moment the clock need to be set an hour ahead</returns>
        public static DateTime SummerTime(int year)
        {
            var lastDayOfMonth = new DateTime(year, 3, 1).AddMonths(1).AddDays(-1);
            return lastDayOfMonth.AddDays((int)lastDayOfMonth.DayOfWeek * -1).AddHours(2);
        }

        /// <summary>
        /// Winter time
        /// </summary>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The moment the clock need to be set an hour back</returns>
        public static DateTime WinterTime(int year)
        {
            var lastDayOfMonth = new DateTime(year, 10, 1).AddMonths(1).AddDays(-1);
            return lastDayOfMonth.AddDays((int)lastDayOfMonth.DayOfWeek * -1).AddHours(3);
        }
        
        /// <summary>
        /// World Animal Day
        /// </summary>
        /// <remarks>
        /// Dutch: Dierendag
        /// </remarks>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime WorldAnimalDay(int year)
        {
            return new DateTime(year, 10, 4);
        }

        /// <summary>
        /// Halloween
        /// </summary>
        /// <param name="year">The year the date should be in</param>
        /// <returns>The date of the holiday</returns>
        public static DateTime Halloween(int year)
        {
            return new DateTime(year, 10, 31);
        }

        public static class Netherlands
        {
            public static DateTime Moederdag(int year)
            {
                return new DateTime(year, 5, 1).AddDays(14 - ((int)new DateTime(year, 5, 1).DayOfWeek == 0 ? 7 : (int)new DateTime(year, 5, 1).DayOfWeek));
            }

            public static DateTime Vaderdag(int year)
            {
                return new DateTime(year, 6, 1).AddDays(21 - ((int)new DateTime(year, 6, 1).DayOfWeek == 0 ? 7 : (int)new DateTime(year, 6, 1).DayOfWeek));
            }

            public static DateTime Koningsdag(int year)
            {
                return new DateTime(year, 4, 27);
            }

            public static DateTime Prinsjesdag(int year)
            {
                return new DateTime(year, 9, 21 - (((int)new DateTime(year, 9, 1).DayOfWeek + 4) % 7));
            }

            public static DateTime Dodenherdenking(int year)
            {
                return new DateTime(year, 5, 4);
            }

            public static DateTime Bevrijdingsdag(int year)
            {
                return new DateTime(year, 5, 5);
            }
        }
    }
}
