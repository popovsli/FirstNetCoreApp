using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{
    public class UserBase
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
    }
}
