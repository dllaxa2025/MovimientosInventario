﻿using System.Web;
using System.Web.Optimization;

namespace Inventario.Web
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new Bundle("~/bundles/complementos").Include(
                        "~/Scripts/fontawesome/all.min.js",
                        "~/Scripts/DataTables/jquery.dataTables.js",
                          "~/Scripts/DataTables/dataTables.responsive.js",
                           "~/Scripts/loadingoverlay/loadingoverlay.min.js",
                            "~/Scripts/sweetalert.min.js",
                               "~/Scripts/jquery-ui.js",
                                "~/Scripts/Chart.min.js",
                                 "~/Scripts/chartjs-plugin-datalabels@2.0.0.js",
                                "~/Scripts/scripts.js"));



            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            //// para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.bundle.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/site.css",
                "~/Content/DataTables/css/jquery.dataTables.css",
                "~/Content/DataTables/css/responsive.dataTables.css",
                  "~/Content/jquery-ui.css",
                  "~/Content/sweetalert.css"
                ));
        }
    }
}
