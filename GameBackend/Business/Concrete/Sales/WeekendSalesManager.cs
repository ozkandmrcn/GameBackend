using GameBackend.Business.Abstract;
using GameBackend.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Business.Concrete.Sales
{
    class WeekendSalesManager: ISalesService
    {
        public void Discount(IEntity game)
        {
            System.Console.WriteLine(game.Name + " oyununa hafta sonu indirimi yapıldı.");
        }

    }
}
