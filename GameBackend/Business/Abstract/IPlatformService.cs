using GameBackend.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Business.Abstract
{
    interface IPlatformService
    {
        void BuyGame(IEntity person, IEntity game);
        void ToRefund(IEntity person, IEntity game);
    }
}
