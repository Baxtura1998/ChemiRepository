using System;

namespace Mexute_Davaleba
{
    class Program
    {
        public static int countVariants(int stearsCount) // Martivi Fibonachis Formula Iyo Dasaweri Da Mcire Rekursia :)
        {
			if (stearsCount <= 1) // Barem Avxsni Kidec.Magaliti moviyvanot 5istvis. Rekursiis Mixedvit Gvaq CV(5)=CV(4)+CV(3),CV(4)=CV(3)+CV(2)
				return 1;//CV(3)=CV(2)+CV(1),CV(2)=CV(1)+CV(0).Pirobis Mixedvit CV(1) da CV(0) orive abrunebs 1-s. Shesabamisad CV(2)=2
			int z = countVariants(stearsCount - 1) + countVariants(stearsCount - 2); //Aqedan Gamomdinare CV(3)=3,CV(4)=5,CV(5)=8,CV(6)=13,
			return z;//CV(7)=21,CV(8)=34,CV(9)=55,CV(10)=89 Da Ase Shemdeg!
		}
        static void Main(string[] args)
        {
            Console.WriteLine("Shemoitanet Kibis Sigrdze, Anu Kibeebis Raodenoba");
            int kibe = Convert.ToInt32(Console.ReadLine());
            int kombinacia = countVariants(kibe);
            Console.WriteLine("Gvaqvs Am Kibis Bolo Safexurze Asvlis " + kombinacia + " Kombinacia!");
        }
    }
}
