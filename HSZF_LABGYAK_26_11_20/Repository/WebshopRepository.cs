using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSZF_LABGYAK_26_11_20.Data;
using HSZF_LABGYAK_26_11_20.Models;
using Microsoft.EntityFrameworkCore;

namespace HSZF_LABGYAK_26_11_20.Repository
{
    public class WebshopRepository : IWebshopRepository
    {
        private readonly WebshopDBContext context;
        //public IEnumerable<Customer> Customers
        //{
        //    get
        //    {
        //        return this.context.Customers.Include(x => x.Orders);
        //    }
        //}

        public WebshopRepository()
        {
            this.context = new WebshopDBContext();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return this.context.Customers.Include(x => x.Orders);
        }

        public IEnumerable<Product> GetProducts()
        {
            return this.context.Products.Include(x => x.Orders);
        }

        public IEnumerable<Order> GetOrders()
        {
            return this.context.Orders.Include(x => x.Customer).Include(x => x.Product);
        }
    }
}
