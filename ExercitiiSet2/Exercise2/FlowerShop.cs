namespace ExercitiiSet2.Exercise2
{
    public class FlowerShop
    {
        private List<Flower> _flowers;
        private List<Bouquet> _bouquets;
        public string Name { get; set; }

        public FlowerShop(string name, List<Flower> flowers, List<Bouquet> bouquets)
        {
            _flowers = flowers;
            _bouquets = bouquets;
            Name = name;
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the flower shop " + Name);
            int option = -1;
            while (option != 0)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. View the flowers");
                Console.WriteLine("2. View the bouquets");
                Console.WriteLine("3. Buy a flower");
                Console.WriteLine("4. Buy a bouqet");
                Console.WriteLine("5. Show inventory for November");
                Console.WriteLine("0. Exit");
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            PrintFlowers();
                            break;
                        case 2:
                            PrintBouquets();
                            break;
                        case 3:
                            BuyFlower();
                            break;
                        case 4:
                            BuyBouqet();
                            break;
                        case 5:
                            PrintInventory();
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

        private void PrintFlowers()
        {
            _flowers.ForEach(flower => Console.WriteLine(flower));
        }

        private void PrintBouquets()
        {
            _bouquets.ForEach(bouquet => Console.WriteLine(bouquet));
        }

        private void BuyFlower()
        {
            Console.WriteLine("The flower you want to buy:");
            string? flowerName = Console.ReadLine();
            Flower? foundFlower = _flowers.FirstOrDefault(flower => flower.Name == flowerName);
            if (foundFlower == null)
            {
                Console.WriteLine("We are sorry, we don't have the flower you want!");
            }
            else
            {
                Console.WriteLine($"Thank you! This will be {foundFlower.Price} RON");
            }
        }

        private void BuyBouqet()
        {
            Console.WriteLine("The bouqet you want to buy:");
            string? bouqetName = Console.ReadLine();
            Bouquet? foundBouquet = _bouquets.FirstOrDefault(bouquet => bouquet.Name == bouqetName);
            if (foundBouquet == null)
            {
                Console.WriteLine("We are sorry, we don't have the bouquet you want!");
            }
            else
            {
                Console.WriteLine("Bouqet informations:");
                Console.WriteLine(foundBouquet);
                Console.WriteLine($"Thank you! This will be {foundBouquet.Price} RON");
            }
        }

        private void PrintInventory()
        {
            int days = 30;
            int dailyRosesSold = 15, dailyGladiolasSold = 10, dailyHydrangeasSold = 25;
            int dailyBigBouqetsSold = 13, dailyMediumBouqetsSold = 10, dailySmallBouqetsSold = 12;
            int smallBouqetPrice = _bouquets[0].Price;
            int mediumBouqetPrice = _bouquets[1].Price;
            int bigBouqetPrice = _bouquets[2].Price;
            int total = 0;

            for (int i = 1; i <= days; i++)
            {
                int dailyTotal = 0;
                Console.WriteLine($"Day {i} of November: ");

                int rosesRevenue = dailyRosesSold * _flowers[0].Price;
                int gladiolasRevenue = dailyGladiolasSold * _flowers[1].Price;
                int hydrangeasRevenue = dailyHydrangeasSold * _flowers[2].Price;
                int smallBouqetsRevenue = dailySmallBouqetsSold * smallBouqetPrice;
                int mediumBouqetsRevenue = dailyMediumBouqetsSold * mediumBouqetPrice;
                int bigBouqetsRevenue = dailyBigBouqetsSold * bigBouqetPrice;

                Console.WriteLine($"{dailyRosesSold} roses sold for a total of {rosesRevenue} RON");
                Console.WriteLine($"{dailyGladiolasSold} gladiolas sold for a total of {gladiolasRevenue} RON");
                Console.WriteLine($"{dailyHydrangeasSold} hydrangeas sold for a total of {hydrangeasRevenue} RON");
                Console.WriteLine($"{dailySmallBouqetsSold} small bouquets sold for a total of {smallBouqetsRevenue} RON");
                Console.WriteLine($"{dailyMediumBouqetsSold} medium bouquets sold for a total of {mediumBouqetsRevenue} RON");
                Console.WriteLine($"{dailyBigBouqetsSold} big bouquets sold for a total of {bigBouqetsRevenue} RON");

                dailyTotal = rosesRevenue + gladiolasRevenue + hydrangeasRevenue + smallBouqetsRevenue + mediumBouqetsRevenue + bigBouqetsRevenue;
                Console.WriteLine($"Daily total sales: {dailyTotal} RON");
                total += dailyTotal;
            }

            Console.WriteLine($"The total sales for month November is {total} RON");
        }

    }
}
}