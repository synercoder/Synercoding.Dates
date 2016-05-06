using System;

namespace Synercoding.Dates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int year = 2016;
            Console.WriteLine("Nieuwjaarsdag:     " + Holidays.NewYearsDay(year));
            Console.WriteLine("Driekoningen:      " + Holidays.Epiphany(year));
            Console.WriteLine("Carneval:          " + Holidays.Carnival(year));
            Console.WriteLine("Valentijn:         " + Holidays.Valentine(year));
            Console.WriteLine("Goede vrijdag:     " + Holidays.GoodFriday(year));
            Console.WriteLine("Pasen:             " + Holidays.Easter(year));
            Console.WriteLine("Dag van de arbeid: " + Holidays.LabourDay(year));
            Console.WriteLine("Hemelvaartsdag:    " + Holidays.AscensionDay(year));
            Console.WriteLine("Pinksteren:        " + Holidays.Pentecost(year));
            Console.WriteLine("Dierendag:         " + Holidays.WorldAnimalDay(year));
            Console.WriteLine("Halloween:         " + Holidays.Halloween(year));
            Console.WriteLine("Sint Maarten:      " + Holidays.SaintMartinsDay(year));
            Console.WriteLine("Sinterklaas:       " + Holidays.SaintNicolasDay(year));
            Console.WriteLine("Kerst:             " + Holidays.Christmas(year));
            Console.WriteLine("Oudejaarsdag:      " + Holidays.NewYearsEve(year));
            Console.WriteLine();
            Console.WriteLine("Zomertijd:         " + Holidays.SummerTime(year));
            Console.WriteLine("Wintertijd:        " + Holidays.WinterTime(year));
            Console.WriteLine();
            Console.WriteLine("Koningsdag:        " + Holidays.Netherlands.Koningsdag(year));
            Console.WriteLine("Moederdag:         " + Holidays.Netherlands.Moederdag(year));
            Console.WriteLine("Vaderdag:          " + Holidays.Netherlands.Vaderdag(year));
            Console.WriteLine("Prinsjesdag:       " + Holidays.Netherlands.Prinsjesdag(year));
            Console.WriteLine("Dodenherdenking:   " + Holidays.Netherlands.Dodenherdenking(year));
            Console.WriteLine("Bevrijdingsdag:    " + Holidays.Netherlands.Bevrijdingsdag(year));

            Console.WriteLine("Done...");
            Console.ReadLine();
        }
    }
}
