using System;
using System.Collections.Generic;

namespace Meore_Davaleba
{
    class Program
    {
        public static int minSplit(int amount)
        {
            int[] myarray = new int[] { 1, 5, 10, 20, 50 }; // Monetebis Masivi, Romlis Mixedvitac Vaxurdavebt
            int m = 0; //Monetebis Raodenoba, Romlis Meshveobitac Chven Shegvidzlia Daxurdaveba, Tavidan Aris 0!
            for(int i=myarray.Length-1;i>=0;i--)
            {
                if ((amount / myarray[i]) > 0)
                {
                    int q = amount / myarray[i];
                    m = m + q;
                    amount = amount - q * myarray[i];
                }
               
            }
                
            return m; //Monetebis Raodenoba
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Shemoitanet Xurdebis Raodenoba");
            int Xurdebi = Convert.ToInt32(Console.ReadLine());
            int k = minSplit(Xurdebi);
            Console.WriteLine("Monetebis Minimaluri Raodenoba, Romlitac Daxurdaveba Shegvidzlia, Aris " + k);
        }
    }
}
