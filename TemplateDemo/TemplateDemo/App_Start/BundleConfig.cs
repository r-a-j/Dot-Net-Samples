using System.Web;
using System.Web.Optimization;

namespace TemplateDemo
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  //"~/Scripts/bootstrap.js"
					  "~/ Scripts/modernizr - 2.6.2.js",
					  "~/ Scripts/jquery.min.js",
					  "~/Scripts/jquery.easing.1.3.js",
					  "~/Scripts/bootstrap.min.js",
					  "~/Scripts/jquery.waypoints.min.js",
					  "~/Scripts/owl.carousel.min.js",
					  "~/Scripts/jquery.countTo.js",
					  "~/Scripts/jquery.stellar.min.js",
					  "~/Scripts/jquery.magnific-popup.min.js",
					  "~/Scripts/magnific-popup-options.js",
					  "~/Scripts/moment.min.js",
					  "~/Scripts/bootstrap-datetimepicker.min.js",
					  "~/Scripts/main.js"
					  ));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  //"~/Content/bootstrap.css",
					  //"~/Content/site.css",
					  "~/css/animate.css",
					  "~/css/icomoon.css",
					  "~/css/themify-icons.css",
					  "~/css/bootstrap.css",
					  "~/css/magnific-popup.css",
					  "~/css/bootstrap-datetimepicker.min.css",
					  "~/css/owl.carousel.min.css",
					  "~/css/owl.theme.default.min.css",
					  "~/css/style.css"
					  ));
		}
	}
}
