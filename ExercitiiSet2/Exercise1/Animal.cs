namespace ExercitiiSet2.Exercise1
{
    public class Animal
    {
        public string? Name { get; set; }
        public AnimalType Type { get; set; }

        public Animal(string name, AnimalType type)
        {
            Name = name;
            Type = type;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type.ToString()}");
        }
    }
}