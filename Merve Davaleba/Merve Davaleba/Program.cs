using System;
using System.Collections;
using System.Collections.Generic;

namespace Merve_Davaleba
{
    class Program
    {
        //Yvela Valuta Ar Aris, Tumca Kodi Sworad Mushaobs
        //Am Funqciit Vavseb Lists
        public static void FillList(List<Tuple<string, double>> Lst)
        {
            Lst.Add(new Tuple<string, double>("USD", 3.2660));
            Lst.Add(new Tuple<string, double>("EUR", 3.9662));
            Lst.Add(new Tuple<string, double>("GEL", 1));
            Lst.Add(new Tuple<string, double>("GBP", 4.3157));
            Lst.Add(new Tuple<string, double>("RUB", 4.3373));
            Lst.Add(new Tuple<string, double>("CHF", 3.6664));
        }
        //Mtavari Funqcia
        public static double ExchangeRate(string from, string to)
        {
            List<Tuple<string, double>> Lst = new List<Tuple<string, double>>();
            FillList(Lst);
            double k = 0;
            for (int i = 0; i < Lst.Count; i++)
            {
                for (int j = 0; j < Lst.Count; j++)
                {
                    if (from == Lst[i].Item1 && to == Lst[j].Item1)
                        k = Lst[i].Item2 / Lst[j].Item2;
                }
            }
            return k;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Shemovitanot Is Valuta, Romlis Konvertaciac Gvinda!");
            string Valuta1 = Console.ReadLine();
            Console.WriteLine("Shemovitanot Is Valuta, Romelzec Vapirebt Konvertacias");
            string Valuta2 = Console.ReadLine();
            double k = ExchangeRate(Valuta1, Valuta2);
            Console.WriteLine("1 " + Valuta1 + " Udris " + k + " " + Valuta2);
        }
    }
}
