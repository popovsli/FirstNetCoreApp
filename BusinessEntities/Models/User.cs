﻿using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities.Interfaces;
using BusinessEntities.Validation;

namespace BusinessEntities.Models
{
    public class User : UserBase
    {
        public User(IValidationStratergy<IUser> validate) : base(validate)
        {

        }
    }
}
