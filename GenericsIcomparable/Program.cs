using GenericsIcomparable.Entities;

class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("How many items:");
            int items = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Box<Products> box = new Box<Products>();

            for (int i = 0; i < items; i++)
            {
                Console.Write("PRODUCT NAME:");
                string name = Console.ReadLine();
                Console.Write("PRODUCT PRICE:");
                double price = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                box.Add(new Products(name, price));
                Console.WriteLine();
            }
            box.Print();
        }catch(FormatException e)
        {
            Console.WriteLine("An error occured: "+ e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine("An error occured: " + e.Message);
        }



    }
}