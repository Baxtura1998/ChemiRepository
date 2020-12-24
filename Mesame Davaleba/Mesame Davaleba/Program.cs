using System;
using System.Collections.Generic;
using System.Linq;
namespace Mesame_Davaleba
{
    class Program
    {
        public static int notContains(int [] Array)
        {
            int m = 0;
            int z = Array.Max(); //Masivis Maqsimaluri Elementi
            List<int> lst = new List<int>(); // Listi
            for(int i=0;i<Array.Length;i++) // Am Operaciit Xdeba Masivis Dadebiti Elementebis Listshi Chawera!
            {
                if (Array[i] > 0)
                    lst.Add(Array[i]);
            }
            int z1 = lst.Min();// Listis(Realurad Masivis) Minimaluri Dadebiti Elementi
            if(z<=1 || z1==1) // Im Shemtxvevashi, Tu Maqsimaluri Elementi Naklebia An Tolia 1-is, An Minimaluri Elementi Udris 1-s, Mashin Amocanis Piroba Ar Sruldeba!
            {
                throw new Exception("Amocanis Piroba Ar Sruldeba!");               
            }
            return 1;// Im Shemtxvevashi, Tu Amocanis Piroba Shesrulda, Mashin Pasuxi Unda Iyos 1, Radgan Es Aris Is Ricxvi, Romelic Metia 0-Ze Da Ar Shedis Masivshi!
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Shemovitanot Masivis Elementebis Raodenoba");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[n];
            Console.WriteLine("Shemovitanot Masivis Elementebi");
            for (int i = 0; i < n; i++)
                Array[i] = Convert.ToInt32(Console.ReadLine());
            int z = notContains(Array);
            //Davbechdot Is Minimaluri Ricxvi
            Console.WriteLine("Minimaluri Ricxvi, Romelic Metia Nulze Da Ar Ekutvins Am Masivs, Anu Am Masivis Minimalur Dadebit" +
                " Elementze Naklebia, Aris "+ z);
        }
    }
}
