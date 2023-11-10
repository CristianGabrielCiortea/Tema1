namespace ExercitiiSet2.Exercise1
{
    public class AnimalShelter
    {
        private List<Animal> _animals;
        private int _capacity;
        public string? Name { get; set; }

        public AnimalShelter(string name, int capacity, List<Animal> animals)
        {
            Name = name;
            _capacity = capacity;
            if (animals.Count <= _capacity)
            {
                _animals = animals;
            }
            else
            {
                Console.WriteLine("Sorry! But we can't take so many of them!:(");
                _animals = new List<Animal>();
            }
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the animal shelter " + Name);
            int option = -1;
            while (option != 0)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add an animal");
                Console.WriteLine("2. See animals");
                Console.WriteLine("3. Adopt an animal");
                Console.WriteLine("0. Exit");
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            AddAnimal();
                            break;
                        case 2:
                            SeeAnimals();
                            break;
                        case 3:
                            RemoveAnimal();
                            break;
                        case 0:
                            Console.WriteLine("Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        private void AddAnimal()
        {
            if (_animals.Count >= _capacity)
            {
                Console.WriteLine("I am sorry, but we don't have room for it!:(");
                return;
            }
            Console.WriteLine("Enter the name of the animal:");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter the type of the animal (Dog/Cat):");
            string? typeString = Console.ReadLine();
            AnimalType type;
            if (Enum.TryParse<AnimalType>(typeString, out type))
            {
                _animals.Add(new Animal(name, type));
                Console.WriteLine("Animal added!");
            }
            else
            {
                Console.WriteLine("Invalid animal type. Please enter 'Dog' or 'Cat'.");
            }
        }

        private void SeeAnimals()
        {
            Console.WriteLine("Animals in the shelter:");
            foreach (var animal in _animals)
            {
                animal.ShowInformation();
            }
        }

        private void RemoveAnimal()
        {
            if( _animals.Count == 0)
            {
                Console.WriteLine("The shelter is empty! You cannot adopt!:(");
            }
            Console.WriteLine("Enter the name of the animal to remove:");
            string? nameToRemove = Console.ReadLine();
            var animalToRemove = _animals.FirstOrDefault(animal => animal.Name == nameToRemove);
            if (animalToRemove != null)
            {
                _animals.Remove(animalToRemove);
                Console.WriteLine("Animal adopted!");
            }
            else
            {
                Console.WriteLine("Animal not found in the shelter.");
            }
        }
    }
}