using OrderProduct;
using OrderSales;

var laptop = new Product(1, "Laptop", 999.99m, "Electronics");
var mouse = new Product(2, "Mouse", 19.99m, "Electronics");
var keyboard = new Product(3, "Keyboard", 49.99m, "Electronics");

var customer = new Customer(1, "John Doe", "johndoe@gmail.com", "Fake Street 123");

var line1 = new SalesOrderLine(1, laptop, 1);
var line2 = new SalesOrderLine(2, mouse, 2);
var line3 = new SalesOrderLine(3, keyboard, 1);

var lines = new List<SalesOrderLine> { line1, line2, line3 };

var order = new SalesOrder(
    id: 1,
    customer: customer,
    lines: lines,
    orderDate: DateTime.Now
);

var deliveryMethod = new DeliveryMethod(
    id: 1,
    name: "DHL",
    typeDelivery: "Standard Delivery",
    hasTracking: true
);

var orders = new List<SalesOrder> { order };

var shipment = new Shipment(
    id: 1,
    deliveryMethod: deliveryMethod,
    orders: orders,
    trackingNumber: "TRACK123456"
);

Console.WriteLine("Shipping Label");
Console.WriteLine($"Customer: {customer.Name}");
Console.WriteLine($"Address:  {customer.Address}");
Console.WriteLine($"Delivery: {deliveryMethod.Name} ({deliveryMethod.TypeDelivery})");
Console.WriteLine($"Tracking: {shipment.TrackingNumber}");
Console.WriteLine();

Console.WriteLine("Packing Slip");
foreach (var line in order.Lines)
{
    Console.WriteLine($"{line.Amount} x {line.Product.Name} = €{line.TotalPrice}");
}

Console.WriteLine($"Total: {order.GetTotal()} euro's");