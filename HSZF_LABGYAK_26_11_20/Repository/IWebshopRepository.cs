using HSZF_LABGYAK_26_11_20.Models;

namespace HSZF_LABGYAK_26_11_20.Repository
{
    public interface IWebshopRepository
    {
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Order> GetOrders();
        IEnumerable<Product> GetProducts();
    }
}