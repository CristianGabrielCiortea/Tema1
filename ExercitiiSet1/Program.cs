using ExercitiiSet1.Exercise7;
using System.Text;

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
        /*
        Determinati daca o secventa de caractere primita ca date de intrare reprezinta o propozitie
        holoalfabetica(o pangrama = un text care foloseste toate literele alfabetului, in cazul nostru
        alegem limba engleza).
        */
        public static bool IsPanagram(string text)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            return alphabet.All(letter => text.ToLower().Contains(letter));
        }
    }

    public static class Exercise3
    {
        /*
        Scrieti o metoda prin care sa schimbati valoarea a doua variabile intre ele, dar fara a va folosi 
        de o a treia variabila. 
        */
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

    public static class Exercise4
    {
        /*Scrieti o metoda care afiseaza numarul de aparitii a fiecarui caracter dintr-un string nenull. */
        public static string DisplayCharacterOccurrences(string text)
        {
            if (text == null) return "null";

            text = text.Trim();
            StringBuilder stringBuilder = new StringBuilder();

            char character = text[0];
            int count = 1;
            for (int i = 1; i < text.Length; i++)
            {
                if (character == text[i])
                {
                    count++;
                }
                else
                {
                    stringBuilder.Append(character);
                    stringBuilder.Append(count);
                    if (Char.IsWhiteSpace(text[i]))
                    {
                        stringBuilder.Append(text[i]);
                        i++;
                    }
                    character = text[i];
                    count = 1;
                }

            }

            return stringBuilder.ToString();
        }
    }

    public static class Exercise5
    {
        /*
        Pornind de la jocul loto 6 din 49, creati un program care simuleaza o runda de jos. Participantul
        introduce 6 numere (intre 1 si 49), iar programul ii raspunde daca este sau nu castigator. Jocul
        este castigat daca numerele introduse de participant sunt aceleasi generate aleator de
        program. Tineti cont ca ordinea nu trebuie sa fie aceeasi.
         */
        public static void StartLotto()
        {
            List<int> playerNumbers = new List<int>();
            Console.WriteLine("Welcome to Lotto!");
            Console.WriteLine("Please choose your numbers!");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(@"Number {0} is: ", i + 1);
                int number;
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (playerNumbers.Contains(number))
                    {
                        Console.WriteLine("You already chose this number, try another one!");
                        i--;
                    }
                    else
                    {
                        playerNumbers.Add(number);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input, please try again!");
                    i--;
                }
            }
            Console.WriteLine("Your numbers are: ");
            playerNumbers.ForEach(number => Console.Write(number + " "));
            Console.WriteLine("\nThe winning numbers are: ");
            var winnerNumbers = GenerateRandomNumbers(1, 69, 6);
            winnerNumbers.ForEach(number => Console.Write(number + " "));

            if (winnerNumbers.Except(playerNumbers).Count() == 0)
            {
                Console.WriteLine("\nCongratulations! You won!");
            }
            else
            {
                Console.WriteLine("\nYou lost :( Better luck next time!");
            }
        }

        private static List<int> GenerateRandomNumbers(int min, int max, int count)
        {
            List<int> randomNumbers = new List<int>();
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                var number = random.Next(min, max);
                if (randomNumbers.Contains(number))
                {
                    i--;
                }
                else
                {
                    randomNumbers.Add(number);
                }
            }

            return randomNumbers;
        }
    }

    public static class Exercise6
    {
        /*
        Pornind de la o lista de nume de elevi, afisati:
        */

        /*a. Alfabetic toate numele ce contin cel putin o data litera a.*/
        public static List<string> OrderElementsThatContainCharacter(List<string> strings, char character)
        {
            return strings.Where(element => element.Contains(character)).OrderBy(element => element).ToList();
        }

        /*b. Toate numele care au cel putin 5 litere.*/
        public static List<string> DeleteElementsThatDontRespectSize(List<string> strings, int size) 
        {
            return strings.Where(element => element.Length >= size).ToList();
        }

        /*c. Numele cel mai scurt din lista.*/
        public static string FindMaximumLengthElement(List<string> strings)
        {
            return strings.MaxBy(element => element.Length);
        }

        /*d. Numele cel mai lung din lista.*/
        public static string FindMinimumLengthElement(List<string> strings)
        {
            return strings.MinBy(element => element.Length);
        }

        /*e. Numarul de aparitii al numelui Alina in lista data.*/
        public static int CountNumberOfOccurrences(List<string> strings, string element)
        {
            return strings.Count(s => s.Equals(element));
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("Exercise 1:");
            Console.WriteLine(@"Sum(5,10)={0}", Exercise1.Sum(5, 10));
            Console.WriteLine(@"SumWithoutPlus(5,10)={0}", Exercise1.SumWithoutPlus(5, 10));
            Console.WriteLine(@"Sum(2.7,7.3)={0}", Exercise1.Sum(2.7, 7.3));
            Console.WriteLine(@"Sum(3,4,5,6,7,8,9,10)={0}", Exercise1.Sum(3, 4, 5, 6, 7, 8, 9, 10));

            //Exercise 2
            Console.WriteLine("Exercise 2:");
            var panagram1 = "The quick brown fox jumps over the lazy dog";
            var panagram2 = "The five boxing wizards jump quickly";
            var panagram3 = "The cat is sleeping on the couch.";

            Console.WriteLine("\n");
            Console.WriteLine(@"IsPanagram('{0}')={1}", panagram1, Exercise2.IsPanagram(panagram1));
            Console.WriteLine(@"IsPanagram('{0}')={1}", panagram2, Exercise2.IsPanagram(panagram2));
            Console.WriteLine(@"IsPanagram('{0}')={1}", panagram3, Exercise2.IsPanagram(panagram3));

            //Exercise 3
            Console.WriteLine("Exercise 3:");
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

            //Exercise 4
            Console.WriteLine("Exercise 4:");
            string text1 = "aaanna issss attt ssschhoooool";
            string text2 = "jjjooon iiis llllooookingggg outsiddeeee thheeee winnnnddddooowww";

            Console.WriteLine("\n");
            Console.WriteLine(@"DisplayCharacterOccurrences('{0})={1}", text1, Exercise4.DisplayCharacterOccurrences(text1));
            Console.WriteLine(@"DisplayCharacterOccurrences('{0})={1}", text2, Exercise4.DisplayCharacterOccurrences(text2));

            //Exercise 5
            Console.WriteLine("Exercise 5:");
            Console.WriteLine("\n");
            Exercise5.StartLotto();
            Console.WriteLine("\n");

            //Exercise 6
            Console.WriteLine("Exercise 6:");
            List<string> students = new List<string>()
            {
                "Marcel",
                "Ioana",
                "Alina",
                "Florentin",
                "Ion",
                "Anamaria",
                "Alina",
                "Cristian",
                "Andrei",
                "Diana",
                "Bogdan",
                "Alina",
                "Ana",
                "Bob"
            };

            Exercise6.OrderElementsThatContainCharacter(students, 'a').ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Exercise6.DeleteElementsThatDontRespectSize(students, 5).ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine(Exercise6.FindMaximumLengthElement(students));
            Console.WriteLine(Exercise6.FindMinimumLengthElement(students));
            Console.WriteLine("Number of occurrences of 'Alina' is: " + Exercise6.CountNumberOfOccurrences(students, "Alina"));
            Console.WriteLine();

            //Exercise 7
            Console.WriteLine("Exercise 7:");
            Student student1 = new Student("Cristian", "Ciortea", "12345", "UNITBV", "Informatica");
            Student student2 = new Student("Andrei", "Popescu", "54321", "UNITBV", "Informatica");
            Student student3 = new Student("Mihai", "Eminescu", "01234", "UNITBV", "Informatica");
            Teacher teacher1 = new Teacher("Florentin", "Popovici", "010101", "UNITBV", "Informatica");
            Teacher teacher2 = new Teacher("Andreea", "Istrate", "111111", "UNITBV", "Informatica");
            Course course1 = new Course("Algoritmi fundamentali", 120, 90, teacher1);
            Course course2 = new Course("Baze de date", 90, 110, teacher2);
            teacher1.Courses.Add(course1);
            teacher2.Courses.Add(course2);
            course1.Students.Add(student1);
            course1.Students.Add(student2);
            course1.Students.Add(student3);
            course2.Students.Add(student1);
            course2.Students.Add(student2);
            course2.Students.Add(student3);
            student1.Courses[course1] = 5;
            student2.Courses[course1] = 7;
            student3.Courses[course1] = 10;
            student1.Courses[course2] = 8;
            student2.Courses[course2] = 9;
            student3.Courses[course2] = 9;

            student1.ShowInformation();
            student2.ShowInformation();
            student3.ShowInformation();
            teacher1.ShowInformation();
            teacher2.ShowInformation();
        }
    }
}