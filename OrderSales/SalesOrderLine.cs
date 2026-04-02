using OrderProduct;

namespace OrderSales;

public class SalesOrderLine
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public int Amount { get; set; }
    public decimal TotalPrice { get; set; }

    public SalesOrderLine(int id, Product product, int amount)
    {
        Id = id;
        Product = product;
        Amount = amount;
        TotalPrice = product.Price * amount;
    }
}