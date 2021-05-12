using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : ICrudDalService
    {
        bool checkIfGamer;

        public bool CheckIfGamer(Gamer gamer)
        {
            int gamerNameLength = gamer.GamerFirstName.Length + gamer.GamerLastName.Length;

            if (gamer.GamerNationallyId.Length != null && gamer.GamerNationallyId.Length == 11 && gamer.GamerDateOfYear> 2003 && gamerNameLength > 5)
            {
                checkIfGamer = true;
            } else
            {
                checkIfGamer = false;
            }
            return checkIfGamer;
        }

        public void Add(Gamer gamer, Game game, Campaign campaign)
        { 
            if (checkIfGamer)
            {
                Console.WriteLine(game.GameName + " adlı oyunucu eklendi");
            }else
            {
                Console.WriteLine(game.GameName + " adlı oyunucu eklenemedi!");
            }
        }

        public void Delete(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.GamerLastName + " adlı oyunucu silindi!");
        }

        public void Update(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.GamerFirstName + " adlı oyunucu güncellendi!");
        }


    }
}
