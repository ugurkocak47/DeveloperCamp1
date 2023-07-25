namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Description = "Amasya apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Description = "Diyarbakır watermelon";

            Product[] products = new Product[] { product1, product2 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + ":    " +
                    product.Price + " - " + "(" + product.Description + ")");
            }

            Console.WriteLine("------------Methods------------");

            //instance - örnek
            //encapsulation

            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);

            cartManager.Add2("Pear","Green pear",12,10);
            cartManager.Add2("Apple", "Green apple", 12,9);
            cartManager.Add2("Watermelon", "Diyarbakır watermelon", 12,8);


           
        }
    }
}