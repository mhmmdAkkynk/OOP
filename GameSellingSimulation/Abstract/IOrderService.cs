using GameSellingSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation.Abstract
{
    public interface IOrderService
    {
        void Order(Customer customer, List<Game> game, Campaign campaign);
    }
}
