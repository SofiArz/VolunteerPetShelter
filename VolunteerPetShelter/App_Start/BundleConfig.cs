using System.Web.Optimization;

namespace VolunteerPetShelter
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css")
               .Include(
                "~/Content/AdminMenu/vendor/bootstrap/css/bootstrap.min.css",          //--Bootstrap Core CSS--
                "~/Content/AdminMenu/vendor/metisMenu/metisMenu.min.css",               //--MetisMenu CSS-- 
                "~/Content/AdminMenu/dist/css/sb-admin-2.css",                          //--Custom CSS-- 
                "~/Content/AdminMenu/vendor/morrisjs/morris.css",                //--Morris Charts CSS --
                "~/Content/AdminMenu/vendor/font-awesome/css/font-awesome.min.css"));   //--Custom Fonts-


                   bundles.Add(new ScriptBundle("~/bundles/js")
              .Include(
                "~/Content/AdminMenu/vendor/jquery/jquery.min.js",           //--jQuery-- 
                "~/Content/AdminMenu/vendor/bootstrap/js/bootstrap.min.js",  //--Bootstrap Core JavaScript--
                "~/Content/AdminMenu/vendor/metisMenu/metisMenu.min.js",     //--Metis Menu Plugin JavaScript-- 
                "~/Content/AdminMenu/vendor/raphael/raphael.min.js",         //--Morris Charts JavaScript--
                "~/Content/AdminMenu/vendor/morrisjs/morris.min.js",
                "~/Content/AdminMenu/data/morris-data.js",
                "~/Content/AdminMenu/dist/js/sb-admin-2.js"));               //--Custom Theme JavaScript--


            bundles.Add(new StyleBundle("~/bundles/homecss")
            .Include(
                 "~/Content/HomeMenu/vendor/bootstrap/css/bootstrap.min.css",
                 "~/Content/HomeMenu/vendor/font-awesome/css/font-awesome.min.css",
                 "~/Content/HomeMenu/vendor/magnific-popup/magnific-popup.css",
                 "~/Content/HomeMenu/css/creative.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/homejs")
            .Include(
                 "~/Content/HomeMenu/vendor/jquery/jquery.min.js",
                 "~/Content/HomeMenu/vendor/bootstrap/js/bootstrap.bundle.min.js",
                 "~/Content/HomeMenu/vendor/jquery-easing/jquery.easing.min.js",
                 "~/Content/HomeMenu/vendor/scrollreveal/scrollreveal.min.js",
                 "~/Content/HomeMenu/vendor/magnific-popup/jquery.magnific-popup.min.js",
                 "~/Content/HomeMenu/js/creative.min.js" ));



 


    

     




        }
    }
}