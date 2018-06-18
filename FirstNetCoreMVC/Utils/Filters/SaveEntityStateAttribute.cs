using AutoMapper;
using FirstNetCoreMVC.Utils.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackableEntities.Common.Core;

namespace FirstNetCoreMVC.Utils.Filters
{
    public class SaveEntityStateAttribute : TypeFilterAttribute
    {
        public SaveEntityStateAttribute() : base(typeof(SaveEntityStateFilter))
        {
        }

        private class SaveEntityStateFilter : IAsyncActionFilter
        {
            private readonly IMapper _mapper;

            public SaveEntityStateFilter(IMapper mapper)
            {
                _mapper = mapper;
            }

            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {
                if (context.ActionArguments.Any(x => x.Value is ITrackable) && context.HttpContext.Request.Method == "POST")
                {
                    context.ActionArguments.Where(x => x.Value is ITrackable).ToList().ForEach(x => context.HttpContext.Session.Remove(x.Value.GetType().ToString()));
                }

                // do something before the action executes
                var resultContext = await next();
                // do something after the action executes; resultContext.Result will be set

                if (resultContext.Result != null && resultContext.Result is ViewResult)
                {
                    var model = (resultContext.Result as ViewResult).Model;

                    context.HttpContext.Session.Set(model.GetType().ToString(), model);
                }

            }
        }
    }


}
