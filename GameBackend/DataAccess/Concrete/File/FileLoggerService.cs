using GameBackend.DataAccess.Abstract;
using GameBackend.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.DataAccess.Concrete.File
{
    class FileLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine(entity.Name + " dosyaya eklendi.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine(entity.Name + " dosyadan kaldırıldı.");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine(entity.Name + " dosyada güncellendi.");
        }
    }
}
