using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Interface
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies { get; }
        Pie GetpieById(int pieId);

    }
}
