namespace OrderSales;

public class DeliveryMethod
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string TypeDelivery { get; set; }
    public bool HasTracking { get; set; }

    public DeliveryMethod(int id, string name, string typeDelivery, bool hasTracking)
    {
        Id = id;
        Name = name;
        TypeDelivery = typeDelivery;
        HasTracking = hasTracking;
    }
}