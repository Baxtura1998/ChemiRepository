using System;

namespace Pirveli_Davaleba
{
    class Program
    {
        //Funqcia
        public static bool isPalindrome(string text)
        {
            for(int i=0;i<text.Length;i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    Console.WriteLine("Ar Aris Palindromi");
                    return false;
                }                                
            }
            Console.WriteLine("Aris Palindromi");
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Shemoitanet Teqsti Da GavigoT, Aris Tu Ara Palindromi");
            string text = Console.ReadLine(); //Shemogvaq Teqsti
            if(true)
                Console.WriteLine(isPalindrome(text)); //Vigebt Palindromia Tu Ara
            //sadsaf
        }
    }
}
