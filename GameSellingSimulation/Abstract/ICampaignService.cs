using GameSellingSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation.Abstract
{
    public interface ICampaignService
    {
        void Save(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
