namespace OrderSales;

public class SalesOrder
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public List<SalesOrderLine> Lines { get; set; }
    public DateTime OrderDate { get; set; }

    public SalesOrder(int id, Customer customer, List<SalesOrderLine> lines, DateTime orderDate)
    {
        Id = id;
        Customer = customer;
        Lines = lines;
        OrderDate = orderDate;
    }

    public decimal GetTotal()
    {

    return Lines.Sum(line => line.TotalPrice);
    
    }

}