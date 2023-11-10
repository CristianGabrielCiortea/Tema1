using ExercitiiSet2.Exercise1;
using ExercitiiSet2.Exercise2;

namespace ExercitiiSet2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. For Animal Shelter Program");
            Console.WriteLine("2. For Flower Shop Program");
            Console.WriteLine("Your option: ");
            int option;
            if (int.TryParse(Console.ReadLine(), out option))
            {
                if (option == 1)
                {
                    string name = "Lovely Animals!";
                    int capacity = 10;
                    List<Animal> list = new List<Animal>()
                    {
                    new Animal("Bob", AnimalType.Dog),
                    new Animal("Smitty", AnimalType.Dog),
                    new Animal("Karla", AnimalType.Cat),
                    new Animal("Frodo", AnimalType.Dog),
                    new Animal("Marie", AnimalType.Cat),
                    new Animal("Queen", AnimalType.Cat),
                    new Animal("Rex", AnimalType.Dog),
                    new Animal("Patrocle", AnimalType.Dog),
                    new Animal("Sam", AnimalType.Cat)
                    };
                    AnimalShelter animalShelter = new AnimalShelter(name, capacity, list);
                    animalShelter.Run();
                }
                else if (option == 2)
                {
                    string name = "Lovely Flowers!";
                    Flower rose = new Flower("Rose", 10);
                    Flower gladiolus = new Flower("Gladiolus", 15);
                    Flower hydrangea = new Flower("Hydrangea", 30);
                    List<Flower> flowers = new List<Flower>()
                    {
                        rose,
                        gladiolus,
                        hydrangea
                    };
                    List<Bouquet> bouquets = new List<Bouquet>()
                    {
                        new Bouquet("Small bouqet", new List<Flower> { rose, rose, rose, rose, rose }),
                        new Bouquet("Medium bouqet", new List<Flower>{ rose, rose, rose, rose, rose, rose, gladiolus, gladiolus, gladiolus, gladiolus, gladiolus }),
                        new Bouquet("Big bouqet", new List<Flower>{ rose, rose, rose, rose, rose, rose, rose, rose, rose, gladiolus, gladiolus, gladiolus, gladiolus, gladiolus,gladiolus, gladiolus, gladiolus, gladiolus, gladiolus, hydrangea, hydrangea, hydrangea }),
                    };
                    FlowerShop flowerShop = new FlowerShop(name, flowers, bouquets);
                    flowerShop.Run();
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

    }
}