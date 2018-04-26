using BusinessLayer.Constant;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Authorization
{
    public class PermissionAuthorizationHandler : IAuthorizationHandler
    {
        public Task HandleAsync(AuthorizationHandlerContext context)
        {
            if(context.Resource is AuthorizationFilterContext mvcContext)
            {
                //mvcContext
            }

            var pendingRequirements = context.PendingRequirements?.ToList();

            foreach (var requirement in pendingRequirements)
            {
                if (requirement is ReadPermission)
                {
                    if (IsOwner(context.User, context.Resource) ||
                        IsSponsor(context.User, context.Resource))
                    {
                        context.Succeed(requirement);
                    }
                }
                else if (requirement is EditPermission ||
                         requirement is DeletePermission)
                {
                    if (IsOwner(context.User, context.Resource))
                    {
                        context.Succeed(requirement);
                    }
                }
                else if(requirement is OperationAuthorizationRequirement)
                {
                    var operationRequirement = requirement as OperationAuthorizationRequirement;
                    if(operationRequirement.Name == Constants.ReadOperationName)
                    {
                        context.Succeed(requirement);
                    }
                }
            }

            //TODO: Use the following if targeting a version of
            //.NET Framework older than 4.6:
            //      return Task.FromResult(0);
            return Task.CompletedTask;
        }

        private bool IsOwner(ClaimsPrincipal user, object resource)
        {
            // Code omitted for brevity

            return true;
        }

        private bool IsSponsor(ClaimsPrincipal user, object resource)
        {
            // Code omitted for brevity

            return true;
        }
    }

    public class ReadPermission : IAuthorizationRequirement
    {

    }

    public class EditPermission : IAuthorizationRequirement
    {

    }

    public class DeletePermission : IAuthorizationRequirement
    {

    }

}
