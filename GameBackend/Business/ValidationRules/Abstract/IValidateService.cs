using GameBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Business.ValidationRules.Abstract
{
    interface IValidateService
    {
        void Validate(Person person);
    }
}
