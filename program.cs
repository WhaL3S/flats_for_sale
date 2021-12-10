class Program
    {
        const int CMsize = 30;
        const string CFd = "FlatsForSale.txt";

        static void Read(string fv, House house)
        {
            using (StreamReader reader = new StreamReader(fv))
            {
                string line;
                while ((line = reader.ReadLine()) != null && house.Get() < CMsize)
                {
                    string[] parts = line.Split(';');
                    int number = int.Parse(parts[0]);
                    int totalArea = int.Parse(parts[1]);
                    int numberOfRooms = int.Parse(parts[2]);
                    int salePrice = int.Parse(parts[3]);
                    int telephoneNumber = int.Parse(parts[4]);
                    Flat flat = new Flat(number, totalArea, numberOfRooms, salePrice, telephoneNumber);
                    house.Add(flat);
                }
            }
        }

        static void Print(House house)
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Number   Total Area    Number of Rooms    Sale Price    Telephone Number");
            Console.WriteLine("------------------------------------------------------------------------");
            for (int i = 0; i < house.Get(); i++)
            {
                Console.WriteLine("{0}", house.Get(i).Table());
                Console.WriteLine("------------------------------------------------------------------------");
            }
        }

        static void Sorted(House house, int N, int P)
        {
            int counter = 0;
            House sortedHouse = new House();
            for (int i = 0; i < house.Get(); i++)
            {
                if (house.Get(i).GetNumberofRooms() == N && house.Get(i).GetSalePrice() <= P)
                {
                    Flat sortedFlat = new Flat(house.Get(i).GetNumber(), house.Get(i).GetTotalArea(), house.Get(i).GetNumberofRooms(), house.Get(i).GetSalePrice(), house.Get(i).GetTelephoneNumber());
                    sortedHouse.Add(sortedFlat);
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No suitable flats are found");
            }
            else
            {
                Print(sortedHouse);
            }
        }

        static void Main(string[] args)
        {
            House house = new House();
            Read(CFd, house);
            Print(house);
            Console.WriteLine("\nPlease enter the number of rooms you want");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease enter the maximum price you want");
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Sorted(house, N, P);
        }
    }
