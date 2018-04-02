using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services.Identity
{
    public class CustomRoleManager<TRole> : RoleManager<TRole>
        where TRole : IdentityRole
    {
        public CustomRoleManager(IRoleStore<TRole> store, 
            IEnumerable<IRoleValidator<TRole>> roleValidators, 
            ILookupNormalizer keyNormalizer, 
            IdentityErrorDescriber errors, 
            ILogger<RoleManager<TRole>> logger) : base(store, roleValidators, keyNormalizer, errors, logger)
        {
        }
    }
}
