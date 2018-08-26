using System.Web;
using System.Web.Optimization;

namespace ZinakeTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {


            bundles.Add(new StyleBundle("~/Scripts/CSS/css").Include(
                         "~/Scripts/CSS/Zinake_2.0.css"));

            bundles.Add(new ScriptBundle("~/Scripts/ScrollMagic/js").Include(
                        "~/Scripts/Javascript/res/jquery.ScrollMagic.js",
                        "~/Scripts/Javascript/res/ScrollMagic.js"));

            bundles.Add(new ScriptBundle("~/Scripts/modernizr").Include(
                        "~/Scripts/JavaScript/cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/jquery").Include(
                        "~/Scripts/JavaScript/res/jquery-2.1.4.js",
                        "~/Scripts/JavaScript/res/jquery.typist.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/JavaScript/js").Include(
                        "~/Scripts/Javascript/cdnjs.cloudflare.com/ajax/libs/typeit/4.2.3/typeit.min.js",
                        "~/Scripts/Javascript/res/typed.min.js",
                        "~/Scripts/Javascript/res/typing-slide-loop2.js",
                        "~/Scripts/Javascript/res/hammer.min.js",
                        "~/Scripts/Javascript/res/jMouseWheel-1.0.min.js",
                        "~/Scripts/Javascript/res/velocity.min.js",
                        "~/Scripts/Javascript/res/velocity.ui.min.js",
                        "~/Scripts/Javascript/vertical-slider.js",
                        "~/Scripts/Javascript/lightslider.js",
                        "~/Scripts/Javascript/main.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.


            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));



        }
    }
}
