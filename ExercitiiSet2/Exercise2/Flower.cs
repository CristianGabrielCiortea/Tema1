namespace ExercitiiSet2.Exercise2
{
    public class Flower
    {
        public string? Name { get; set; }
        public int Price { get; set; }

        public Flower(string name, int price) 
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "Flower name: " + Name + ", Price: " + Price;
        }
    }
}