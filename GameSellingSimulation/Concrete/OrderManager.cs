using GameSellingSimulation.Abstract;
using GameSellingSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation.Concrete
{
    class OrderManager : IOrderService
    {
        public void Order(Customer customer, List<Game> game, Campaign campaign)
        {
            //Her oyuna tek tek indirim uygulanır.
            var gamePrice = 0m;
            foreach (var value in game)
            {
                gamePrice = value.GamePrice - (value.GamePrice * campaign.DiccountRate) / 100;
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " bought the game named " + value.GameName + " for " + gamePrice + " TL with the " + campaign.CampaignName + " campaign.");
            }
        }
    }
}
