using System.Web;
using System.Web.Optimization;

namespace IoniSolarzCom.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/assets/js/plugins/jquery-1.*",
                "~/assets/js/plugins/bootstrap.min.js",
                "~/assets/js/plugins/smoothscroll.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/assets/css/bootstrap.min.css",
                "~/assets/css/bootstrap-responsive.min.css",
                "~/assets/css/main.css"));
        }
    }
}
