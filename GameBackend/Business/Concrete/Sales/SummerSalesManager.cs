using GameBackend.Business.Abstract;
using GameBackend.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Business.Concrete.Sales
{
    class SummerSalesManager: ISalesService
    {
        public void Discount(IEntity game)
        {
            Console.WriteLine(game.Name + " oyununa yaz indirimi yapıldı.");
        }

       
    }
}
