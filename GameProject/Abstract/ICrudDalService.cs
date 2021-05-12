using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICrudDalService
    {
        void Add(Gamer gamer, Game game, Campaign campaign);
        void Delete(Gamer gamer, Game game, Campaign campaign);
        void Update(Gamer gamer, Game game, Campaign campaign);
    }
}
