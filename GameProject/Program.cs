using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                FirstName = "BEYZA",
                LastName = "ÇETİNER",
                IdentityNumber = 12345
            };

          
            GamerManager gamerManager = new GamerManager(new UserValidationManager());   //OYUNCU
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.Update(gamer1);

            Console.WriteLine("***********************************");

            Campaign campaign1 = new Campaign { CampaignName = "Sezon sonu büyük indirim" };     //KAMPANYA
            Campaign campaign2 = new Campaign { CampaignName = "%50 indirim" };
            Campaign campaign3 = new Campaign { CampaignName = "Son fırsatlar" };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign3);

            //campaignManager.Add(new Campaign { CampaignName = "Sezon sonu büyük indirim" });
            //campaignManager.Delete(new Campaign { CampaignName = "%50 indirim" });
            //campaignManager.Update(new Campaign { CampaignName = "Son fırsatlar" });
            Console.WriteLine("******************************************");

            OrderManager orderManager = new OrderManager();           //SATIŞ
            orderManager.Order(gamer1, campaign1);
            orderManager.Order(gamer1, campaign2);
            orderManager.Order(gamer1, campaign3);


            Console.ReadLine();
        }
    }
}
