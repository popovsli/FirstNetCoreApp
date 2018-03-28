using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{

    //When implementing a role storage provider,
    //you can create a custom role type. It need not implement a particular interface,
    //but it must have an Id and typically it will have a Name property.
    public class Role : IdentityRole
    {

    }
}
