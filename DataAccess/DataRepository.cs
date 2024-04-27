using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class DataRepository
    {
        private static List<string> orders = new List<string>();

        public List<string> GetAllOrders()
        {
            return orders;
        }

        public void AddOrder(string order)
        {
            orders.Add(order);
        }
    }
    public class MyDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }
    }
    public class Order
    {
        public int OrderID { get; set; }  // Corresponde a la clave primaria
        public DateTime OrderDate { get; set; }  // Fecha del pedido
        public required string CustomerName { get; set; }  // Nombre del cliente
        public required string ProductName { get; set; }  // Nombre del producto
        public int Quantity { get; set; }  // Cantidad del producto
        public decimal Price { get; set; }  // Precio del producto
    }
}
