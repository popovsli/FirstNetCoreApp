using BusinessEntities.Interfaces;
using BusinessEntities.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{
    public abstract class UserBase : IUser
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        public bool IsAdmin { get; set; }


        public UserBase(IValidationStratergy<IUser> validate)
        {
            _validationType = validate;
        }

        private IValidationStratergy<IUser> _validationType = null;
        public IValidationStratergy<IUser> ValidationType
        {
            get
            {
                return _validationType;
            }
            set
            {
                _validationType = value;
            }
        }

        public bool Validate()
        {
           return ValidationType.Validate(this);
        }
    }
}
