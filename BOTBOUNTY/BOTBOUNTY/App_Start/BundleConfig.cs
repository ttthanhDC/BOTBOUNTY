using System.Web;
using System.Web.Optimization;

namespace BOTBOUNTY
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                       "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/template/js").Include(
                      "~/Template/js/admin.js"));

            bundles.Add(new ScriptBundle("~/bundles/template/plugins/bootstrap-select").Include(
                      "~/Template/plugins/bootstrap-select/js/bootstrap-select.js"));

            bundles.Add(new ScriptBundle("~/bundles/template/plugins/jquery-slimscroll").Include(
                      "~/Template/plugins/jquery-slimscroll/jquery.slimscroll.js"));

            bundles.Add(new ScriptBundle("~/bundles/template/plugins/node-wavesjs").Include(
                      "~/Template/plugins/node-waves/waves.js"));

            bundles.Add(new ScriptBundle("~/bundles/template/plugins/node-wavescss").Include(
                      "~/Template/plugins/node-waves/waves.css"));

            bundles.Add(new ScriptBundle("~/bundles/template/plugins/animate-css").Include(
                      "~/Template/plugins/animate-css/animate.css"));

            bundles.Add(new ScriptBundle("~/bundles/template/css").Include(
                      "~/Template/plugins/css/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/template/css/themes").Include(
                      "~/Template/plugins/css/themes/all-themes.css"));

            bundles.Add(new ScriptBundle("~/bundles/template/plugins/bootstrap/css").Include(
                      "~/Template/plugins/bootstrap/css/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/template/plugins/jquery").Include(
                      "~/Template/plugins/jquery/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/template/plugins/bootstrap/js").Include(
                      "~/Template/plugins/bootstrap/js/bootstrap.js"));





        }
    }
}
