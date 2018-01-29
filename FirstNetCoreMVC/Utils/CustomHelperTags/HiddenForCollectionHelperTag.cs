using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirstNetCoreMVC.Utils.CustomHelperTags
{
    public static class HiddenForCollectionHelperTag
    {
        public static HtmlString HiddenForCollection<TModel, TProperty>(this HtmlHelper<TModel> html, Expression<Func<TModel, TProperty>> expression) where TProperty : ICollection
        {
            var model = html.ViewData.Model;
            var property = model != null
                        ? expression.Compile().Invoke(model)
                        : default(TProperty);

            var result = new StringBuilder();
            if (property != null && property.Count > 0)
            {
                for (int i = 0; i < property.Count; i++)
                {
                    var modelExp = expression.Parameters.First();
                    var propertyExp = expression.Body;
                    var itemExp = Expression.ArrayIndex(propertyExp, Expression.Constant(i));

                    var itemExpression = Expression.Lambda<Func<TModel, object>>(itemExp, modelExp);

                    result.AppendLine(html.HiddenFor(itemExpression).ToString());
                }
            }
            return new HtmlString(result.ToString());
           // return new MvcHtmlString(result.ToString());
        }
    }
}
