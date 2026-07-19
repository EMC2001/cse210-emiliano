using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        List<Product> products1 = new List<Product>();
        List<Product> products2 = new List<Product>();

//Order 1
        Address address1 = new Address("51 S", "Rexburg", "Idaho", "USA");

        Customer customer1 = new Customer("Eric Eduardo", address1);

        Product product1 = new Product("Laptop", "Personal-Computer", 200, 1);
        Product product2 = new Product("iPhone 16", "Cellular Phone", 1200, 2);
        Product product3 = new Product("Snickers", "Chocolate Bar", 1, 1);

        products1.Add(product1);
        products1.Add(product2);
        products1.Add(product3);

        Order order1 = new Order(customer1, products1);

        orders.Add(order1);

//Order 2
        Address address2 = new Address("36 N 1st E", "Reynosa", "Tamaulipas", "Mexico");

        Customer customer2 = new Customer("Emiliano Medina", address2);

        Product product4 = new Product("Laptop", "Personal-Computer", 200, 3);
        Product product5 = new Product("Ford 2005", "Vehicle", 2000, 1);
        Product product6 = new Product("iPhone", "Cellular Phone", 1200, 2);

        products2.Add(product4);
        products2.Add(product5);
        products2.Add(product6);

        Order order2 = new Order(customer2, products2);

        orders.Add(order2);

//Printing Orders
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order Total:${order1.OrderTotal()} Shipping Charge:${order1.ShippingCharge()}");

        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Order Total:${order2.OrderTotal()} Shipping Charge:${order2.ShippingCharge()}");
    }
}