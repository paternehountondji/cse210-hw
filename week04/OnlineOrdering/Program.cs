using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Phone Case", "P001", 15.00, 2));
        order1.AddProduct(new Product("Charger", "P002", 10.00, 1));
        order1.AddProduct(new Product("Screen Protector", "P003", 5.00, 3));

        Address address2 = new Address("45 Rue de Paris", "Paris", "Ile-de-France", "France");
        Customer customer2 = new Customer("Marie Dubois", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P004", 25.00, 1));
        order2.AddProduct(new Product("Power Bank", "P005", 20.00, 2));

        Order[] orders = { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
            Console.WriteLine();
        }
    }
}