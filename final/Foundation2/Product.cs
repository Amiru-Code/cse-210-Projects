public class Product
{
    private string _name;
    private string _productID;
    private float _pricePerUnit;
    private int _quantity;

    public Product(string name, string productID, float pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _quantity = quantity;
        _pricePerUnit = pricePerUnit;
    }

    public float GetPricePerUnit() => _pricePerUnit;
    public int GetQuantity() => _quantity;
    public string GetProductName() => _name;
    public string GetProductID() => _productID;


}