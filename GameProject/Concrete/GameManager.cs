using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : ICrudDalService
    {
        public void Add(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " adlı oyun " + game.GamePrice + "TL fiyatıyla yayımlandı!");
        }

        public void Delete(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " adlı oyun yayımdan kaldırıldı!");
        }

        public void Update(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " adlı oyun güncellendi!");
        }
    }
}
