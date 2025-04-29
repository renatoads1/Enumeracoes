
using Enumeracoes;
using Enumeracoes.Entities;

Order order = new Order
{
    Id = 1,
    Product = "Laptop",
    Quantity = 2,
    Price = 1500.00,
    Status = OrderStatus.Processing
};
Console.WriteLine(order.ToString());