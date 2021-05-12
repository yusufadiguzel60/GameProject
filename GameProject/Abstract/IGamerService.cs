using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGamerService
    {
        void TakeGame();
        void DoGiftGame(Gamer gamer);
    }
}
