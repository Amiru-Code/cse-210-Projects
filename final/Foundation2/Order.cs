public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order( List<Product> products, Customer customer )
    {
        _products = products;
        _customer = customer;
    }

    public void addProduct(Product product)
    {
        _products.Add(product);
    }

    public float GetTotalCost()
    {
        float cost = 0;
        foreach(Product item in _products)
        {
            cost += item.GetPricePerUnit() * item.GetQuantity();
        }

        if( _customer.LivesInUsa() == true)
        {
            cost += 5;
        }
        else
        {
            cost += 35;
        }
        return cost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach(Product item in _products)
        {
            packingLabel += $" {item.GetProductName()}, {item.GetProductID()},";
        }
    return packingLabel;
    }

    public string GetShippingLabel()
    {
        {
            string shippingLabel = "";
            shippingLabel += $" {_customer.GetCustomerName()}, {_customer.GetCustomerAddress().GetFullAddress()}";
            return shippingLabel;
        }
    }
    }