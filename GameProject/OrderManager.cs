using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        public void Order(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine( gamer.FirstName + " " + gamer.LastName + " adlı oyuncu için oyun satıldı. "
                + campaign.CampaignName + " adlı kampanya kullanıldı.");
        }
    }
}
