using Enumeracoes.Entities;
using Enumeracoes.Enum;

Order order = new Order
{
    Id = 1,
    Product = "Laptop",
    Quantity = 2,
    Price = 1500.00,
    Status = OrderStatus.Processing
};
Console.WriteLine(order.ToString());

string st = OrderStatus.PendingPayment.ToString();
Console.WriteLine(st);

OrderStatus os = Enum.Parse<OrderStatus>("Shipped");
Console.WriteLine(os.ToString());