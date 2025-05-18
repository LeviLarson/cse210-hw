using System;

class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address address1 = new Address("123 John Doe Road", "Rexburg", "ID", "USA");
            Address address2 = new Address("456 Maple Ave", "Ontario", "ON", "Canada");

            // Create customers
            Customer customer1 = new Customer("John Smith", address1);
            Customer customer2 = new Customer("Steve Minecraft", address2);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Laptop", "L1001", 999.99, 1));
            order1.AddProduct(new Product("Mouse", "M2002", 25.50, 2));

            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Headphones", "H3003", 75.00, 1));
            order2.AddProduct(new Product("Keyboard", "K4004", 49.99, 1));
            order2.AddProduct(new Product("Webcam", "W5005", 89.95, 1));

            // Display order details
            List<Order> orders = new List<Order> { order1, order2 };

            foreach (Order order in orders)
            {
                Console.WriteLine(order.GetPackingLabel());
                Console.WriteLine(order.GetShippingLabel());
                Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
                Console.WriteLine(new string('-', 40));
            }
        }
    }