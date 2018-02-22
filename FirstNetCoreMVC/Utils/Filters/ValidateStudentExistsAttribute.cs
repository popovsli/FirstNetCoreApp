using BusinessEntities.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FirstNetCoreMVC.Common.Constants;

namespace FirstNetCoreMVC.Utils.Filters
{
    public class ValidateStudentExistsAttribute : TypeFilterAttribute
    {
        public ValidateStudentExistsAttribute() : base(typeof(ValidateStudentExistsFilter))
        {
        }

        private class ValidateStudentExistsFilter : IAsyncActionFilter
        {
            private readonly MovieContext _dbContext;

            public ValidateStudentExistsFilter(MovieContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {
                if (context.ActionArguments.ContainsKey("id"))
                {
                    int? studentID = context.ActionArguments["id"] as int?;
                    if (studentID.HasValue)
                    {
                        if (!_dbContext.Person.Any(x => x.Id == studentID))
                        {
                            context.Result = new NotFoundObjectResult(ErrorCode.RecordNotFound.ToString());
                            return;
                        }
                    }
                }
                await next();
            }
        }
    }
}
