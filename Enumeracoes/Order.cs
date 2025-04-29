using Enumeracoes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes
{
    public class Order
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"Order ID: {Id}, Product: {Product}, Quantity: {Quantity}, Price: {Price}, Status: {Status}";
        }

    }

}
