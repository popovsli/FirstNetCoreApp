using BusinessEntities.Interfaces;
using BusinessEntities.Models;
using BusinessEntities.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Validation.UserValidation
{
    public class UserBaseValidation : IValidationStratergy<IUserBase>
    {
        public bool Validate(IUserBase obj)
        {
            return obj.IsAdmin;
        }
    }
}
