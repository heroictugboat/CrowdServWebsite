using System.Web;
using System.Web.Optimization;

namespace CrowdServWebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-route.js",
                      "~/Scripts/angular-animate.js",
                      // app files
                      "~/app/app.module.js",
                      "~/app/app.route.js",
                      // services
                      "~/app/components/about/aboutService.js",
                      "~/app/components/home/homeService.js",
                      "~/app/components/team/teamService.js",
                      "~/app/components/contact/contactService.js",
                      // controllers
                      "~/app/components/about/aboutController.js",
                      "~/app/components/home/homeController.js",
                      "~/app/components/team/teamController.js",
                      "~/app/components/contact/contactController.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/material").Include(
                      //"~/Scripts/material.js",
                      "~/Scripts/material.min.js",
                      //"~/Scripts/material.min.js.map",
                      //"~/Scripts/ripples.js"
                      "~/Scripts/ripples.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/style.css",
                      //"~/Content/bootstrap.css",
                      //"~/Content/bootstrap.min.css",
                      //"~/Content/Site.css",
                      //"~/Content/material.css",
                      //"~/Content/material.css.map",
                      "~/Content/material-fullpalette.min.css",
                      //"~/Content/material.min.css.map",
                      //"~/Content/ripples.css",
                      //"~/Content/ripples.css.map",
                      "~/Content/ripples.min.css",
                      //"~/Content/ripples.min.css.map",
                      //"~/Content/roboto.css"
                      //"~/Content/roboto.css.map",
                      "~/Content/roboto.min.css"
                      //"~/Content/roboto.min.css.map"
                      ));
        }
    }
}
