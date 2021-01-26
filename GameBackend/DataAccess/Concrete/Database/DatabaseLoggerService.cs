using GameBackend.DataAccess.Abstract;
using GameBackend.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.DataAccess.Concrete.Database
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine(entity.Name + " veritabanına eklendi.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine(entity.Name + " veritabanından kaldırıldı.");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine(entity.Name + " veritabanında güncellendi.");
        
        }
    }
}
