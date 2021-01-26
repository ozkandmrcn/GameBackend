using GameBackend.Abstract;
using GameBackend.Business.ValidationRules.Abstract;
using GameBackend.DataAccess.Abstract;
using GameBackend.Entities.Abstract;
using GameBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Business.Concrete
{
    class PlayerManager : IEntityService
    {
        List<ILoggerService> _loggerServices;
        List<IValidateService> _validateServices;
        public PlayerManager(List<ILoggerService> loggerServices, List<IValidateService> validateServices)
        {
            _loggerServices = loggerServices;
            _validateServices = validateServices;
        }


        public void Add(IEntity person)
        {
            try
            {
                foreach (var validator in _validateServices)
                {
                    validator.Validate((Person)person);
                }
                foreach (var logger in _loggerServices)
                {
                    logger.Add(person);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }

        public void Delete(IEntity person)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(person);
            }
        }

        public void Update(IEntity person)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Update(person);
            }

        }
    }
}
