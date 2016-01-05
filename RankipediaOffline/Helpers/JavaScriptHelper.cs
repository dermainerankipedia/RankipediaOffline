using System.Globalization;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace RankipediaOffline.Helpers
{
    /// <summary>
    /// Javascript HTML helper members.
    /// </summary>
    public static class JavaScriptHelper
    {
        public static IHtmlString Json(this HtmlHelper helper, object data)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new JsonConverter[]
                {
                    new StringEnumConverter(),
                },
                StringEscapeHandling = StringEscapeHandling.EscapeHtml
            };

            return MvcHtmlString.Create(JsonConvert.SerializeObject(data, settings));
        }

        /// <summary>
        /// Returns the angular js template
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="modelPrefix"></param>
        /// <returns></returns>
        public static IHtmlString AngularEditorForModel(this HtmlHelper helper, string modelPrefix)
        {
            return helper.EditorForModel("Angular/Object", new {Prefix = modelPrefix});
        }

        /// <summary>
        /// Returns the angular js models for binding
        /// </summary>
        /// <param name="helper"></param>
        /// <returns></returns>
        public static IHtmlString AngularBindingForModel(this HtmlHelper helper)
        {
            var prefix = (string) (helper.ViewBag.Prefix);

            if (prefix != null)
            {
                prefix = prefix + ".";
            }

            return MvcHtmlString.Create(prefix + helper.CamelCaseIdForModel());
        }

        public static string CamelCaseIdForModel(this HtmlHelper helper)
        {
            var input = helper.IdForModel().ToString();

            if (string.IsNullOrEmpty(input) || !char.IsUpper(input[0]))
            {
                return input;
            }

            var sb = new StringBuilder();

            for (int index = 0; index < input.Length; index++)
            {
                var flag = index + 1 < input.Length;
                if (index == 0 || !flag || char.IsUpper(input[index + 1]))
                {
                    var ch = char.ToLower(input[index], CultureInfo.InvariantCulture);
                    sb.Append(ch);
                }
                else
                {
                    sb.Append(input.Substring(index));
                    break;
                }
            }

            return sb.ToString();
        }
    }
}