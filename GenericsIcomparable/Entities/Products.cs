namespace GenericsIcomparable.Entities
{
    class Products : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Products))
            {
                throw new ArgumentException("ERROR");
            }
            Products product = obj as Products;
            return Price.CompareTo(product.Price);
        }

        public override string ToString()
        {
            return "NAME:" + Name + ", PRICE:" + Price.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
