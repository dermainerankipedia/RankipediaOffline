using System.Web;
using System.Web.Optimization;

namespace RankipediaOffline
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/respond.js")
                .Include("~/Scripts/angular.js")
                .Include("~/Scripts/angular-route.js")
                .Include("~/Scripts/angular-ui/ui-bootstrap.js")
                .Include("~/Scripts/angular-ui/ui-bootstrap-tpls.js")
                .Include("~/Scripts/xeditable.js")
                .Include("~/Scripts/checklist-model.js")
                .Include("~/Scripts/profile/cropAvatar.js")
                .Include("~/Scripts/profile/cropper.js")
                // .IncludeDirectory("~/app/", "*.js", true)

                .Include("~/app/RankipediaApp.js")
                .Include("~/app/fileupload/cropAvatarUploadDirective.js")
                .Include("~/app/profile/profileBriefController.js")
                .Include("~/app/profile/profileController.js")
                .Include("~/app/profile/profileRoutes.js")
                .Include("~/app/profile/profileService.js")
                .Include("~/app/profile/templates/profileBriefDirective.js")
                 .Include("~/app/directives/templates/addresscontactListDirective.js")
                  .Include("~/app/directives/templates/phoneContactListDirective.js")
                .Include("~/app/services/alert.js")
                .Include("~/app/services/cropAvatarUploadService.js")
                .Include("~/app/services/exceptionOverride.js")
                );

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/font-awesome.css")
                .Include("~/Content/site.css")
                .Include("~/Content/sidemenu.css")
                .Include("~/Content/profile.css")
                .Include("~/Content/xeditable.css")
                .Include("~/Content/profile/cropAvatar.css")
                .Include("~/Content/profile/cropper.css")
                );
        }
    }
}
