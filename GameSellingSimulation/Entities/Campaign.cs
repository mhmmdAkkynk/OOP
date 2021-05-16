using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int DiccountRate { get; set; }
    }
}
