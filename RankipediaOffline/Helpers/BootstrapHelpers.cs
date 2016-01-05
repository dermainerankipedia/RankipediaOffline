using System;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace RankipediaOffline.Helpers
{
    public static class BootstrapHelpers
    {
        /// <summary>
        /// Wraps the standard labelfor extension with boostrap label css class.
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="helper"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public static IHtmlString BootstrapLabelFor<TModel, TProp>(this HtmlHelper<TModel> helper,
            Expression<Func<TModel, TProp>> property)
        {
            return helper.LabelFor(property, new {@class = "col-md-2 control-label"});
        }

        /// <summary>
        /// Wraps the standard labelfor extension with boostrap label css class.
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public static IHtmlString BootstrapLabel(this HtmlHelper helper,
            string property)
        {
            return helper.Label(property, new { @class = "col-md-2 control-label" });
        }

    }
}