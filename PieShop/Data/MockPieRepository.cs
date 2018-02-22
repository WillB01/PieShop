using PieShop.Interface;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Data
{
    public class MockPieRepository : IPieRepository
    {
        public IEnumerable<Pie> GetAllPies => new List<Pie>()
        {
            new Pie(){Id = 1, Name = "Apple Pie", Price = 23},
            new Pie(){Id = 2, Name = "BlueBerry Pie", Price = 140},
            new Pie(){Id = 3, Name = "Strawberry Pie", Price = 50},
        };

        public Pie GetpieById(int pieId)
        {
            return GetAllPies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
