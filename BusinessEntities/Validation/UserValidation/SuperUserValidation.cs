using BusinessEntities.Interfaces;
using BusinessEntities.Models;
using BusinessEntities.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Validation.UserValidation
{
    public class SuperUserValidation2 : IValidationStratergy<IUser>
    {
        public bool Validate(IUser obj)
        {
            return obj.IsAdmin;
        }
    }
}
