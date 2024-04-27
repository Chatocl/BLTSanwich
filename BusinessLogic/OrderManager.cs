using DataAccess;

namespace BusinessLogic
{
    public class OrderManager
    {
        private DataRepository Repository;

        public OrderManager()
        {
            Repository = new DataRepository();
        }

        public void PlaceOrder(string order)
        {
            // Aquí podrías añadir lógica adicional (validaciones, reglas de negocio, etc.)
            Repository.AddOrder(order);
        }

        public string GetAllOrders()
        {
            return string.Join(", ", Repository.GetAllOrders());
        }
    }
}
