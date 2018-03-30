using BusinessEntities.Models;
using BusinessEntities.Models.ContosoUniversity;
using BusinessLayer.Services.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using BusinessLayer.Constant;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Authorization
{
    public class ContactIsOwnerAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, Contact>
    {
        CustomUserManager<User> _userManager;
        public ContactIsOwnerAuthorizationHandler(CustomUserManager<User>
        userManager)
        {
            _userManager = userManager;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, Contact resource)
        {
            if (context.User == null || resource == null)
            {
                return Task.FromResult(0);
            }
            // If we're not asking for CRUD permission, return.
            if (requirement.Name != Constants.CreateOperationName &&
            requirement.Name != Constants.ReadOperationName &&
            requirement.Name != Constants.UpdateOperationName &&
            requirement.Name != Constants.DeleteOperationName)
            {
                return Task.FromResult(0);
            }
            if (resource.UserId == _userManager.GetUserId(context.User))
            {
                context.Succeed(requirement);
            }
            return Task.FromResult(0);
        }
    }
}
