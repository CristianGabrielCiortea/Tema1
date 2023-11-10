namespace ExercitiiSet2.Exercise2
{
    public class Bouquet
    {
        public string? Name { get; set; }
        public List<Flower> Flowers { get; set; }

        public int Price
        {
            get
            {
                int price = 2; //2 for assembly
                Flowers.ForEach(flower => price += flower.Price);
                return price;
            }
        }

        public Bouquet(string name, List<Flower> flowers)
        {
            Name = name;
            Flowers = flowers;
        }

        public override string ToString()
        {
            string flowerList = string.Join("\n", Flowers.Select(flower => flower.ToString()));
            return $"Bouquet Name: {Name}, Flowers: \n{flowerList}";
        }
    }
}