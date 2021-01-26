using GameBackend.Business.Abstract;
using GameBackend.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Business.Concrete.Platforms
{
    class EpicGamesPlatformManager : IPlatformService
    {
        List<ISalesService> _salesServices;
        public EpicGamesPlatformManager(List<ISalesService> salesServices)
        {
            _salesServices = salesServices;
        }
        public void BuyGame(IEntity person, IEntity game)
        {
            foreach (var sale in _salesServices)
            {
                sale.Discount(game);
            }
            Console.WriteLine(person.Name + " " + game.Name + " oyununu Epic Games'ten satın aldı.");
        }

        public void ToRefund(IEntity person, IEntity game)
        {
            Console.WriteLine(person.Name + " " + game.Name + " oyununu Epic Games'e iade etti.");
        }
    }
}
