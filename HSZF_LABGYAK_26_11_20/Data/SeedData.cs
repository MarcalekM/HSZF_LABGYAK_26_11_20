using HSZF_LABGYAK_26_11_20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSZF_LABGYAK_26_11_20.Data
{
    internal class SeedData
    {
        public static Customer[] Customers =>
        [
            new() { Id = 1, Name = "Kiss Anna", City = "Budapest" },
            new() { Id = 2, Name = "Nagy Péter", City = "Debrecen" },
            new() { Id = 3, Name = "Tóth Eszter", City = "Budapest" },
            new() { Id = 4, Name = "Szabó Bence", City = "Szeged" },
            new() { Id = 5, Name = "Horváth Lili", City = "Győr" },
            new() { Id = 6, Name = "Varga Máté", City = "Budapest" },
            new() { Id = 7, Name = "Kovács Dóra", City = "Pécs" },
            new() { Id = 8, Name = "Molnár Ádám", City = "Debrecen" },
        ];

        public static Product[] Products =>
        [
            new() { Id = 1, Name = "Vezeték nélküli egér", Category = "Elektronika", Price = 8990 },
            new() { Id = 2, Name = "Mechanikus billentyűzet", Category = "Elektronika", Price = 29990 },
            new() { Id = 3, Name = "27 colos monitor", Category = "Elektronika", Price = 89990 },
            new() { Id = 4, Name = "USB-C töltő", Category = "Elektronika", Price = 6990 },
            new() { Id = 5, Name = "C# kezdőknek", Category = "Könyv", Price = 7490 },
            new() { Id = 6, Name = "Tiszta kód", Category = "Könyv", Price = 9990 },
            new() { Id = 7, Name = "Kávéfőző", Category = "Otthon", Price = 34990 },
            new() { Id = 8, Name = "Asztali lámpa", Category = "Otthon", Price = 12990 },
            new() { Id = 9, Name = "Jógamatrac", Category = "Sport", Price = 9490 },
            new() { Id = 10, Name = "Futócipő", Category = "Sport", Price = 39990 },
        ];

        public static Order[] Orders =>
        [
            new() { Id = 1,  OrderDate = new DateTime(2026, 9, 3),   CustomerId = 1, ProductId = 3,  Quantity = 1 },
            new() { Id = 2,  OrderDate = new DateTime(2026, 9, 3),   CustomerId = 1, ProductId = 1,  Quantity = 2 },
            new() { Id = 3,  OrderDate = new DateTime(2026, 9, 10),  CustomerId = 2, ProductId = 5,  Quantity = 3 },
            new() { Id = 4,  OrderDate = new DateTime(2026, 9, 15),  CustomerId = 3, ProductId = 7,  Quantity = 1 },
            new() { Id = 5,  OrderDate = new DateTime(2026, 9, 22),  CustomerId = 4, ProductId = 10, Quantity = 1 },
            new() { Id = 6,  OrderDate = new DateTime(2026, 9, 28),  CustomerId = 6, ProductId = 4,  Quantity = 4 },
            new() { Id = 7,  OrderDate = new DateTime(2026, 10, 2),  CustomerId = 2, ProductId = 2,  Quantity = 1 },
            new() { Id = 8,  OrderDate = new DateTime(2026, 10, 5),  CustomerId = 3, ProductId = 6,  Quantity = 2 },
            new() { Id = 9,  OrderDate = new DateTime(2026, 10, 9),  CustomerId = 5, ProductId = 8,  Quantity = 2 },
            new() { Id = 10, OrderDate = new DateTime(2026, 10, 14), CustomerId = 1, ProductId = 5,  Quantity = 1 },
            new() { Id = 11, OrderDate = new DateTime(2026, 10, 18), CustomerId = 6, ProductId = 3,  Quantity = 1 },
            new() { Id = 12, OrderDate = new DateTime(2026, 10, 21), CustomerId = 8, ProductId = 1,  Quantity = 3 },
            new() { Id = 13, OrderDate = new DateTime(2026, 10, 30), CustomerId = 4, ProductId = 7,  Quantity = 1 },
            new() { Id = 14, OrderDate = new DateTime(2026, 11, 2),  CustomerId = 5, ProductId = 6,  Quantity = 1 },
            new() { Id = 15, OrderDate = new DateTime(2026, 11, 4),  CustomerId = 2, ProductId = 4,  Quantity = 2 },
            new() { Id = 16, OrderDate = new DateTime(2026, 11, 8),  CustomerId = 3, ProductId = 2,  Quantity = 1 },
            new() { Id = 17, OrderDate = new DateTime(2026, 11, 11), CustomerId = 8, ProductId = 10, Quantity = 2 },
            new() { Id = 18, OrderDate = new DateTime(2026, 11, 15), CustomerId = 6, ProductId = 1,  Quantity = 1 },
            new() { Id = 19, OrderDate = new DateTime(2026, 11, 19), CustomerId = 1, ProductId = 8,  Quantity = 1 },
            new() { Id = 20, OrderDate = new DateTime(2026, 11, 20), CustomerId = 4, ProductId = 5,  Quantity = 2 },
        ];
    }
}
