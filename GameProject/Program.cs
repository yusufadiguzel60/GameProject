using System;
using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Campaign campaign = new Campaign { CamapignId = 1, CampaignName = "Süper Mayıs" };
            Gamer gamer = new Gamer { GamerId = 2, GamerFirstName = "Yusuf", GamerLastName = "Adıgüzel", GamerNationallyId = "24563178326", GamerDateOfYear = 2003 };
            Game game = new Game { GameId = 3, GameName = "PUBG", GamePrice = 17.99 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(gamer, game, campaign);
            campaignManager.DoFree(campaign, game);
            campaignManager.DoDiscount(campaign, game);

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer, game, campaign);
            gamerManager.Delete(gamer, game, campaign);
            gamerManager.Update(gamer, game, campaign);

            GameManager gameManager = new GameManager();
            gameManager.Add(gamer, game, campaign);
            gameManager.Delete(gamer, game, campaign);
            gameManager.Update(gamer, game, campaign);

        }
    }
}