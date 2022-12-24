using StoreProduct.Enum;

namespace StoreProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            do
            {
                Console.WriteLine("Product elave etmek isteyiriz? y/n(orAnyKeyword)");
                string asnwer = Console.ReadLine();
                if (asnwer == "y")
                {
                    Console.WriteLine("Productun adin daxil edin:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Productun qiymetini daxil edin :");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Type-in daxil edin: 1.Baker 2.Drink 3.Meat");
                    int type = Convert.ToInt32(Console.ReadLine());
                    Product product = new Product
                    {
                        Name = name,
                        Price = price,
                        Type = (ProductType)type
                    };
                    store.AddProduct(product);
                }
                else
                {
                    break;
                }
            } while (true);

            bool check = true;

            while (check)
            {
                Console.WriteLine("Ashagidaki menudan birin secin:");
                Console.WriteLine("1.RemoveProductByNo (silmek istediyiniz productun nomresini daxil edin)");
                Console.WriteLine("2.FilterProductsByType (type'a gore filter edin)");
                Console.WriteLine("3.FilterProductByName (ada gore filter edin)");
                Console.WriteLine("0. Proqrami Bitir");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Bir nomre daxil edin:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        store.RemoveProductByNo(number);
                        store.GetInfo();
                        break;
                    case "2":
                        Console.WriteLine("Bir Type daxil daxil edin: 1.Baker 2.Drink 3.Meat");
                        int type = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in store.FilterProductsByType((ProductType)type))
                        {
                            Console.WriteLine($"Nomresi {item.No}  Adi- {item.Name} -- Qiymeti -- {item.Price} manat  Type : {item.Type}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Productun adini daxil edin:");
                        string name = Console.ReadLine();
                        foreach (var item in store.FilterProductByName(name))
                        {
                            Console.WriteLine($"Nomresi {item.No} Adi- {item.Name} -- Qiymeti -- {item.Price} manat  Type : {item.Type}");
                        }
                        break;

                    case "0":
                        store.GetInfo();
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Zehmet olmasa duzgun secim daxil edin");
                        break;
                }
            }
        }
    }
}