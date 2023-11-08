

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

    public static class Exercise3
    {
        public static void Swap(ref int x, ref int y)
        {
            x += y;
            y = x - y;
            x -= y;
        }

        public static void Swap(ref double x, ref double y)
        {
            x += y;
            y = x - y;
            x -= y;
        }

        public static void Swap(ref float x, ref float y)
        {
            x += y;
            y = x - y;
            x -= y;
        }

        public static void Swap(ref string x, ref string y)
        {
            x = x + y;
            y = x.Substring(0, x.Length - y.Length);
            x = x.Substring(y.Length);
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine(@"Sum(5,10)={0}", Exercise1.Sum(5, 10));
            Console.WriteLine(@"SumWithoutPlus(5,10)={0}", Exercise1.SumWithoutPlus(5, 10));
            Console.WriteLine(@"Sum(2.7,7.3)={0}", Exercise1.Sum(2.7, 7.3));
            Console.WriteLine(@"Sum(3,4,5,6,7,8,9,10)={0}", Exercise1.Sum(3, 4, 5, 6, 7, 8, 9, 10));

            //Exercise 2
            var panagram1 = "The quick brown fox jumps over the lazy dog";
            var panagram2 = "The five boxing wizards jump quickly";
            var panagram3 = "The cat is sleeping on the couch.";

            Console.WriteLine("\n");
            Console.WriteLine(@"IsPanagram('{0}')={1}", panagram1, Exercise2.IsPanagram(panagram1));
            Console.WriteLine(@"IsPanagram('{0}')={1}", panagram2, Exercise2.IsPanagram(panagram2));
            Console.WriteLine(@"IsPanagram('{0}')={1}", panagram3, Exercise2.IsPanagram(panagram3));

            //Exercise 3
            int a1 = 2, b1 = 3;

            Console.WriteLine("\n");
            Console.WriteLine(@"a={0}, b={1}", a1, b1);
            Console.WriteLine("Swapping..");
            Exercise3.Swap(ref a1, ref b1);
            Console.WriteLine(@"a={0}, b={1}", a1, b1);

            double a2 = 3.5, b2 = 5.6;

            Console.WriteLine(@"a={0}, b={1}", a2, b2);
            Console.WriteLine("Swapping..");
            Exercise3.Swap(ref a2, ref b2);
            Console.WriteLine(@"a={0}, b={1}", a2, b2);

            string a3 = "string1", b3 = "string2";

            Console.WriteLine(@"a={0}, b={1}", a3, b3);
            Console.WriteLine("Swapping..");
            Exercise3.Swap(ref a3, ref b3);
            Console.WriteLine(@"a={0}, b={1}", a3, b3);

        }
    }
}