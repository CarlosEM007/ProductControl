using ProductControl.Entities;


Console.Write("Enter the number of products: ");

int Nproducts;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out Nproducts))
    {
        break;
    }
    Console.WriteLine("Enter a valid number\n");
}

List<Product> products = new List<Product>();

for (int i = 1; i <= Nproducts; i++)
{
    Console.WriteLine($"Product #{i} Data");
    Console.WriteLine("Common, used or imported (c, u, i) ?");

    while (true)
    {
        string? choice = Console.ReadLine();

        if(choice == "c")
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            products.Add(new Product(name, price));
            break;
        }
        else if(choice == "u")
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Manufacture Date (DD/MM/YYYY): ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            products.Add(new UsedProducts(name, price, data));
            break;
        }
        else if(choice == "i")
        {
            Console.Write("Name: ");
            string? name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Custom fee: ");
            double fee = double.Parse(Console.ReadLine());

            products.Add(new ImportedProducts(name, price, fee));
            break;
        }
        else
        {
            Console.WriteLine("Valor Inválido!");
            break;
        }
    }
}

Console.WriteLine("Price Tags: ");
foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}