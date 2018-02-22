using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Interface
{
    public interface IFeedbackRepository
    {
        void AddFeedBack(Feedback feedback);
    }
}
