using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSZF_LABGYAK_26_11_20.Data;
using HSZF_LABGYAK_26_11_20.Models;
using HSZF_LABGYAK_26_11_20.Repository;
using Microsoft.EntityFrameworkCore;

namespace HSZF_LABGYAK_26_11_20.Logic
{
    internal class WebshopLogic
    {
        private readonly IWebshopRepository repository;

        public WebshopLogic(IWebshopRepository repository)
        {
            this.repository = repository;
        }

        public int GetCustomerCount()
        {
            return this.repository.GetCustomers().Count();
        }

        public int GetOrdersFrom202610()
        {
            return this.repository.GetOrders().Count(o => o.OrderDate.Year == 2026 && o.OrderDate.Month == 10);
        }

        public record KatGroup(string kat, int darab, double avg);

        public List<KatGroup> GetKatGroups()
        {
            return this.repository.GetProducts()
                .GroupBy(p => p.Category)
                .OrderByDescending(g => g.Average(p => p.Price))
                .Select(g => new KatGroup(g.Key, g.Count(), g.Average(p => p.Price)))
                .ToList();
        }

        public record Koltes(string name, int amount);
        public List<Koltes> GetKoltes()
        {
            return this.repository.GetCustomers()
                .Where(c => c.Orders.Any())
                .Select(c => new
                {
                    Name = c.Name,
                    Total = c.Orders.Sum(o => o.Quantity * o.Product.Price)
                })
                .OrderByDescending(k => k.Total)
                .Select(k => new Koltes(k.Name, k.Total))
                .ToList();
        }

        public record BestProduct(Product product, int quantity);

        public List<BestProduct> GetBestProducts()
        {
            var query = this.repository.GetOrders()
                .Select(o => new { Product = o.Product, Quantity = o.Quantity })
                .GroupBy(o => o.Product)
                .Select(g => new BestProduct(g.Key, g.Sum(o => o.Quantity)));

            var max = query.Max(p => p.quantity);

            return query.Where(q => q.quantity == max).ToList();
        }
    }
}
