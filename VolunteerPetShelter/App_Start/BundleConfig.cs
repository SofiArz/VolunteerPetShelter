using System.Web.Optimization;

namespace VolunteerPetShelter
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css")
               .Include(
                "~/Content/vendor/bootstrap/css/bootstrap.min.css",          //--Bootstrap Core CSS--
                "~/Content/vendor/metisMenu/metisMenu.min.css",               //--MetisMenu CSS-- 
                "~/Content/dist/css/sb-admin-2.css",                          //--Custom CSS-- 
                "~/Content/vendor/morrisjs/morris.css",                //--Morris Charts CSS --
                "~/Content/vendor/font-awesome/css/font-awesome.min.css"));   //--Custom Fonts-


                   bundles.Add(new ScriptBundle("~/bundles/js")
              .Include(
                "~/Content/vendor/jquery/jquery.min.js",           //--jQuery-- 
                "~/Content/vendor/bootstrap/js/bootstrap.min.js",  //--Bootstrap Core JavaScript--
                "~/Content/vendor/metisMenu/metisMenu.min.js",     //--Metis Menu Plugin JavaScript-- 
                "~/Content/vendor/raphael/raphael.min.js",         //--Morris Charts JavaScript--
                "~/Content/vendor/morrisjs/morris.min.js",
                "~/Content/data/morris-data.js",
                "~/Content/dist/js/sb-admin-2.js"));               //--Custom Theme JavaScript--


        }
    }
}