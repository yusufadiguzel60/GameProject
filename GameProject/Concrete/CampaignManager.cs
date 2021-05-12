using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICrudDalService, ICamapignService
    {
        public void Add(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName +  " adlı kampanya eklendi!");
        }

        public void Delete(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya silindi!");
        }

        public void DoDiscount(Campaign campaign, Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyunun " + campaign.CampaignName + " kampanyasıyla indirime girdi!" );
        }

        public void DoFree(Campaign campaign, Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun " + campaign.CampaignName + " adlı ka");
        }

        public void Update(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya güncellendi!");
        }
    }
}
