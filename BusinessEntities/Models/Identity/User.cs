﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BusinessEntities.Models.Identity
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    //At a minimum, your user class must include an Id and a UserName property if you not inhereted from IdentityUser.
    public class User : IdentityUser
    {

    }
}
