using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("51 S", "Rexburg", "Idaho", "USA");
        Console.WriteLine(address.DomesticAddressOrNot());

        Customer customer = new Customer("Eric Eduardo", address);
        Console.WriteLine(customer.GetCustomerName());
        Console.WriteLine(customer.GetCustomerAddress());
        Console.WriteLine(customer.NationalAddress());

        Product product = new Product("Laptop", "Personal-Computer", 200, 2);
        Console.WriteLine(product.GetProductName());
        Console.WriteLine(product.GetProductID());
        Console.WriteLine(product.GetProductTotalPrice());
    }
}