using BusinessEntities.Interfaces;
using BusinessEntities.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{
    public class UserBase : IUserBase
    {

        private string _fullName;

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        public bool IsAdmin { get; set; }
               

        public UserBase(IValidationStratergy<IUserBase> validate)
        {
            _validationType = validate;
        }

        private IValidationStratergy<IUserBase> _validationType = null;
        public IValidationStratergy<IUserBase> ValidationType
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
    }
}
