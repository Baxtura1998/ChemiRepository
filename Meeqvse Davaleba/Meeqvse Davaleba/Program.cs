using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Meeqvse_Davaleba
{
    class Program
    {
        //Funqcias Viyeneb Elementebis Gamosaxvistvis
        public static void Gamosaxva(LinkedList<int> ricxvebi, string ricxvi)
        {
            foreach (int ricxvi1 in ricxvebi)
                Console.WriteLine(ricxvi + " " + ricxvi1);
        }
        static void Main(string[] args)
        {
            //Monacemta Struqtura
            int[] ricxvebi = new int[] { 9, -5, 13, 139, -123, 1000, 1203421 };
            LinkedList<int> MyList = new LinkedList<int>(ricxvebi);
            Gamosaxva(MyList, "Gvaq Shemdegi Monacemebi:");
            //Monacemta Struqtura Shlis Ukanasknel Elements Da Amas Andomebs O(1) Dros.
            Console.WriteLine("Elementis Washlis Shemdeg Gvaq");
            MyList.RemoveLast();
            Gamosaxva(MyList, "Gvaq Shemdegi Monacemebi:");
        }
    }
}
