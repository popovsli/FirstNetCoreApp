using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities.Interfaces;
using BusinessEntities.Validation;

namespace BusinessEntities.Models
{
    public class SuperUser : UserBase
    {
        public string Role { get; set; }

        public SuperUser(IValidationStratergy<IUser> validate) : base(validate)
        {

        }

    }
}
