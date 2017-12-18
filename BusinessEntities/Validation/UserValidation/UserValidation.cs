using BusinessEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Validation.UserValidation
{
    public class UserValidation : IValidationStratergy<IUser>
    {
        public bool Validate(IUser obj)
        {
            throw new NotImplementedException();
        }
    }
}
