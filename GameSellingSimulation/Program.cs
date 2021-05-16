using GameSellingSimulation.Abstract;
using GameSellingSimulation.Adapters;
using GameSellingSimulation.Concrete;
using GameSellingSimulation.Entities;
using System;
using System.Collections.Generic;

namespace GameSellingSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Muhammed";
            customer.LastName = "Akkaynak";
            customer.DateOfBirth = new DateTime(1998, 5, 24);
            customer.NationalityId = "38060085088";

            ICustomerService customerService = new CustomerManager(new MernisServiceAdapter());
            customerService.Save(customer);

            Game gameGTA = new Game();
            gameGTA.Id = 1;
            gameGTA.GameName = "GTA V";
            gameGTA.GamePrice = 299.99m;

            Game gameFifa = new Game();
            gameFifa.Id = 1;
            gameFifa.GameName = "Fifa 2021";
            gameFifa.GamePrice = 425m;

            GameManager gameManager = new GameManager();
            gameManager.Save(gameGTA);


            Campaign campaignBlackFriday = new Campaign();
            campaignBlackFriday.Id = 1;
            campaignBlackFriday.CampaignName = "Black Friday";
            campaignBlackFriday.DiccountRate = 25;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Save(campaignBlackFriday);

            List<Game> gameList = new List<Game>() { gameGTA, gameFifa };

            OrderManager orderManager = new OrderManager();
            orderManager.Order(customer, gameList, campaignBlackFriday);
        }
    }
}
