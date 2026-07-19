using System.Numerics;

class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public decimal AllProductsTotal()
    {
        decimal total = 0;
        foreach(Product product in _products)
        {
            total += product.GetProductTotalPrice();
        }

        return total;
    }

    public decimal ShippingCharge()
    {
        decimal shipping;
        if(_customer.NationalAddress() == true)
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }

        return shipping;
    }

    public decimal OrderTotal()
    {
        return AllProductsTotal()+ShippingCharge();
    }

    public string PackingLabel()
    {
        string packingLabel = "";

        foreach(Product product in _products)
        {
            packingLabel += $"Product Name: {product.GetProductName()} - Product ID:{product.GetProductID()}\n";
        }

        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = "";

            shippingLabel += $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress().GetAddress()}";

        return shippingLabel;
    }
}