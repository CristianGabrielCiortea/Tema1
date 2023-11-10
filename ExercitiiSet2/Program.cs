using ExercitiiSet2.Exercise1;

namespace ExercitiiSet2
{
    public class Program
    {
        public static void Main(string[] args)
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

    }
}