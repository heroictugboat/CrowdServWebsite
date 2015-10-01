﻿using System.Web;
using System.Web.Optimization;

namespace CrowdServ
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

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/scss").Include(
                       "~/Content/angular-material/angular-material.css",
                      "~/Content/Styles/Bundled.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-route.js",
                      // angular material
                      "~/Scripts/angular-animate.js",
                      "~/Scripts/angular-aria.js",
                      "~/Scripts/angular-material.js",
                      // app files
                      "~/app/app.module.js",
                      "~/app/app.route.js",
                      // services
                      "~/app/components/about/aboutService.js",
                      "~/app/components/contact/contactService.js",
                      "~/app/components/home/homeService.js",
                      "~/app/components/team/teamService.js",
                      // controllers
                      "~/app/components/about/aboutController.js",
                      "~/app/components/contact/contactController.js",
                      "~/app/components/home/homeController.js",
                      "~/app/components/team/teamController.js"
                      ));
        }
    }
}
