

namespace ExercitiiSet1
{
    public static class Exercise1
    {
        /*a.Scrieti o metoda care calculeaza suma celor doua numere primite ca parametri.*/
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        /*b.Calculati suma numerelor fara a folosi operatorul “+”.*/
        public static int SumWithoutPlus(int x, int y)
        {

            return x - (-y);
        }

        /*c.Aplicati conceptul de overloading (suprascriere) pentru aceasta metoda*/
        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static float Sum(float x, float y)
        {
            return x + y;
        }

        /*d.Adaugati posibilitatea de-a calcula suma a 3, 4, 5, etc./numar variabil de numere.*/
        public static int Sum(params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }
    }

    public static class Exercise2
    {
        /*Determinati daca o secventa de caractere primita ca date de intrare reprezinta o propozitie
         holoalfabetica(o pangrama = un text care foloseste toate literele alfabetului, in cazul nostru
         alegem limba engleza).*/
        public static bool IsPanagram(string text)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            return alphabet.All(letter => text.ToLower().Contains(letter));
        }
    }

    public class Program
    { 
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine(@"Sum(5,10)={0}", Exercise1.Sum(5,10));
            Console.WriteLine(@"SumWithoutPlus(5,10)={0}", Exercise1.SumWithoutPlus(5,10));
            Console.WriteLine(@"Sum(2.7,7.3)={0}", Exercise1.Sum(2.7,7.3));
            Console.WriteLine(@"Sum(3,4,5,6,7,8,9,10)={0}", Exercise1.Sum(3,4,5,6,7,8,9,10));
        }
    }
}