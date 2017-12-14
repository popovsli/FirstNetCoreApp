using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Interfaces
{
    public interface IUserBase
    {
        string UserName { get; set; }

        string Password { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string FullName { get; }

        bool IsAdmin { get; set; }
    }
}
