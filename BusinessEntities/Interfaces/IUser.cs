using BusinessEntities.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Interfaces
{
    public interface IUser
    {
        string UserName { get; set; }

        string Password { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string FullName { get; }

        bool IsAdmin { get; set; }

        IValidationStratergy<IUser> ValidationType { get; }

        bool Validate();
    }
}
