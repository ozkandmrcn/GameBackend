using GameBackend.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Business.Abstract
{
    interface ISalesService
    {
        void Discount(IEntity entitiy);
    }
}
