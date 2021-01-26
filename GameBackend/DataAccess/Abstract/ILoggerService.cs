using GameBackend.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.DataAccess.Abstract
{
    interface ILoggerService
    {
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}
