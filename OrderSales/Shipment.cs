namespace OrderSales;

public class Shipment
{
    public int Id { get; set; }
    public DeliveryMethod DeliveryMethod { get; set; }
    public List<SalesOrder> Orders { get; set; }
    public string TrackingNumber { get; set; }

    public Shipment(int id, DeliveryMethod deliveryMethod, List<SalesOrder> orders, string trackingNumber)
    {
        Id = id;
        DeliveryMethod = deliveryMethod;
        Orders = orders;
        TrackingNumber = trackingNumber;
    }
}