using System.Web.Mvc;

namespace RankipediaOffline.Extensions
{
    public static class UrlHelperExtensions
    {
        public static string StaticImage(this UrlHelper helper, string fileName)
        {
            return helper.Content("~/Content/images/" + fileName);
        }

        public static string StaticUrl(this UrlHelper helper, string fileName)
        {
            return helper.Content("~/" + fileName);
        } 
    }
}