using GameSellingSimulation.Abstract;
using GameSellingSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Save(Campaign campaign)
        {
            Console.WriteLine("The campaign named " + campaign.CampaignName + " has been added to campaign list!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("The campaign named " + campaign.CampaignName + " has been updated!");
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("The campaign named" + campaign.CampaignName + " has been deleted from the campaign list!");
        }

    }
}
