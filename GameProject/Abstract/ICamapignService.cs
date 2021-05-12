using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICamapignService
    {
        void DoDiscount(Campaign campaign, Game game);
        void DoFree(Campaign campaign, Game game);
    }
}
