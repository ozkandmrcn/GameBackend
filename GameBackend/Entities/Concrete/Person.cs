﻿using GameBackend.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Entities.Concrete
{
    class Person:IEntity
    {
        public string NationalityNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
    }
}
