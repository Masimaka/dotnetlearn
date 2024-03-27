namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }
        public override bool Equals(object obj)
        {
            var product = obj as Product;

            if (product == null)
                return false;

            return Name == product.Name && Price == product.Price;
        }

        // // При переопределении Equals рекомендуется также переопределить GetHashCode
        // public override int GetHashCode()
        // {
        //     return Name.GetHashCode() ^ Price.GetHashCode();
        // }
    }
}
