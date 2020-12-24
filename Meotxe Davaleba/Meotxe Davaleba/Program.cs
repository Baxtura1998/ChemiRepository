using System;
using System.Collections.Generic;

namespace Meotxe_Davaleba
{
    class Program
    {
        public static bool Pair(char x1, char x2)
        {
            if (x1 == '(' && x2 == ')')
            {
                return true;
            }
            return false;
        }
        // Listit Mindoda Gaketeba, Tumca Queue-ti Gavakete :)))
        public static bool isProperly(string sequence)
        {
            Queue<char> myqueue = new Queue<char>();
            if (sequence[0] == ')')
                return false; // Tu Sityva Iwyeba ) it Mashin ukve arasworia
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '(') // Tu Sityva Iwyeba ) it Mashin Emateba
                    myqueue.Enqueue(sequence[i]);
                if (sequence[i] == ')')
                {
                    if (myqueue.Count == 0) // Tu Konteineri Aris Carieli, Anu Am )-s Ar hyavs Megobari!
                    {
                        return false;
                    }
                    else if (!Pair(myqueue.Dequeue(),
                                        sequence[i])) //Xdeba Konteineris Dacarieleba Zeda Elementit. Tu Is Ar Warmoadgens Wyvils, Mashin Gvaq Erori.
                    {
                        return false;
                    }
                }
            }
            if (myqueue.Count == 0) // Tu Steki Dacarielda, Mashin Sworia, Tu Arada Erori!
            {
                Console.WriteLine("Frchxilebi Sworad Aris Dasmuli");
                return true;
            }
            else
            {
                Console.WriteLine("Frchxilebi Arasworad Aris Dasmuli");
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Shemoitanet Sityva, Romelic Shedgeba Mxolod ,,('' Da ,,('' Elementebisgan <3");
            string elementebi = Console.ReadLine();
            var k = isProperly(elementebi);
            Console.WriteLine(k);
        }
    }
}
