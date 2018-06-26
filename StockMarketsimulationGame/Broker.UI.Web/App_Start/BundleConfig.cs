using System.Web;
using System.Web.Optimization;

namespace Broker.UI.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 59c751f50057a435c080c6a1d406702026bff2b6
                        "~/Scripts/jquery-{version}.js",
                        //"~/Scripts/jquery-1.10.2.intellisense.js",
                        "~/Scripts/jquery-1.10.2.js",
                        "~/Scripts/jquery-1.10.2.min.js"));
<<<<<<< HEAD
=======
=======
                          "~/Scripts/jquery-{version}.js",
                          //"~/Scripts/jquery-1.10.2.intellisense.js",
                          "~/Scripts/jquery-1.10.2.js",
                          "~/Scripts/jquery-1.10.2.min.js"));
>>>>>>> 5c0c5f8a2ba390f128684b1234fb848c82a46819
>>>>>>> 59c751f50057a435c080c6a1d406702026bff2b6

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.validate-vsdoc.js",
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/WinAlert").Include(

               "~/Scripts/WinAlert/jquery.ui.effect.min.js",
               "~/Scripts/WinAlert/AlertJS.js",
               "~/Scripts/WinAlert/geniealert.win8.js"
               ));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new StyleBundle("~/Content/WinAlert").Include(
                     "~/Content/WinAlert/AlertCSS.css",
                     "~/Content/WinAlert/style.win8.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/bootstrap.css",
                       "~/Content/bootstrap.min.css",
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 59c751f50057a435c080c6a1d406702026bff2b6
                       "~/Content/jqx.android.css",
                       "~/Content/jqx.arctic.css",
                       "~/Content/jqx.base.css",
                       "~/Content/jqx.blackberry.css",
                       "~/Content/jqx.black.css",
                       "~/Content/jqx.bootstrap.css",
<<<<<<< HEAD
=======
=======
                        "~/Content/jqx.android.css",
                 "~/Content/jqx.arctic.css",
                 "~/Content/jqx.base.css",
                 "~/Content/jqx.blackberry.css",
                 "~/Content/jqx.black.css",
                 "~/Content/jqx.bootstrap.css",
>>>>>>> 5c0c5f8a2ba390f128684b1234fb848c82a46819
>>>>>>> 59c751f50057a435c080c6a1d406702026bff2b6
                 "~/Content/jqx.classic.css",
                 "~/Content/jqx.dark.css",
                 "~/Content/jqx.darkblue.css",
                 "~/Content/jqx.energyblue.css",
                 "~/Content/jqx.flat.css",
                 "~/Content/jqx.fresh.css",
                 "~/Content/jqx.glacier.css",
                 "~/Content/jqx.highcontrast.css",
                 "~/Content/jqx.light.css",
                 "~/Content/jqx.metro.css",
                 "~/Content/jqx.metrodark.css",
                 "~/Content/jqx.mobile.css",
                 "~/Content/jqx.office.css",
                 "~/Content/jqx.orange.css",
                 "~/Content/jqx.ui-darkness.css",
                 "~/Content/jqx.summer.css",
                 "~/Content/jqx.ui-le-frog.css",
                 "~/Content/jqx.ui-lightness.css",
                 "~/Content/jqx.ui-overcast.css",
                 "~/Content/jqx.ui-redmond.css",
                 "~/Content/jqx.ui-smoothness.css",
                 "~/Content/jqx.ui-start.css",
                 "~/Content/jqx.ui-sunny.css",
                 "~/Content/jqx.web.css",
                 "~/Content/jqx.windowsphone.css",
                 "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqwidgets").Include(
                "~/Scripts/jqx-all.js",
                "~/Scripts/jqxangular.js",
                "~/Scripts/jqxbargauge.js",
                "~/Scripts/jqxbulletchart.js",
                "~/Scripts/jqxbuttongroup.js",
                "~/Scripts/jqxbuttons.js",
                "~/Scripts/jqxcalendar.js",
                "~/Scripts/jqxchart.annotations.js",
                "~/Scripts/jqxchart.api.js",
                "~/Scripts/jqxchart.core.js",
                "~/Scripts/jqxchart.js",
                "~/Scripts/jqxchart.rangeselector.js",
                "~/Scripts/jqxchart.waterfall.js",
                "~/Scripts/jqxcheckbox.js",
                "~/Scripts/jqxcolorpicker.js",
                "~/Scripts/jqxcombobox.js",
                "~/Scripts/jqxcomplexinput.js",
                "~/Scripts/jqxcore.elements.js",
                "~/Scripts/jqxcore.js",
                "~/Scripts/jqxdata.export.js",
                "~/Scripts/jqxdata.js",
                "~/Scripts/jqxdatatable.js",
                "~/Scripts/jqxdate.js",
                "~/Scripts/jqxdatetimeinput.js",
                "~/Scripts/jqxdocking.js",
                "~/Scripts/jqxdockinglayout.js",
                "~/Scripts/jqxdockpanel.js",
                "~/Scripts/jqxdragdrop.js",
                "~/Scripts/jqxdraw.js",
                "~/Scripts/jqxdropdownbutton.js",
                "~/Scripts/jqxdropdownlist.js",
                "~/Scripts/jqxeditor.js",
                "~/Scripts/jqxexpander.js",
                "~/Scripts/jqxfileupload.js",
                "~/Scripts/jqxformattedinput.js",
                "~/Scripts/jqxgauge.js",
                "~/Scripts/jqxgrid.aggregates.js",
                "~/Scripts/jqxgrid.columnsreorder.js",
                "~/Scripts/jqxgrid.columnsresize.js",
                "~/Scripts/jqxgrid.edit.js",
                "~/Scripts/jqxgrid.export.js",
                "~/Scripts/jqxgrid.filter.js",
                "~/Scripts/jqxgrid.grouping.js",
                "~/Scripts/jqxgrid.js",
                "~/Scripts/jqxgrid.pager.js",
                "~/Scripts/jqxgrid.selection.js",
                "~/Scripts/jqxgrid.sort.js",
                "~/Scripts/jqxgrid.storage.js",
                "~/Scripts/jqxkanban.js",
                "~/Scripts/jqxinput.js",
                "~/Scripts/jqxknob.js",
                "~/Scripts/jqxknockout.js",
                "~/Scripts/jqxlayout.js",
                "~/Scripts/jqxlistbox.js",
                "~/Scripts/jqxlistmenu.js",
                "~/Scripts/jqxloader.js",
                "~/Scripts/jqxmenu.js",
                "~/Scripts/jqxnavbar.js",
                "~/Scripts/jqxmaskedinput.js",
                "~/Scripts/jqxnavigationbar.js",
                "~/Scripts/jqxnotification.js",
                "~/Scripts/jqxnumberinput.js",
                "~/Scripts/jqxpanel.js",
                "~/Scripts/jqxpasswordinput.js",
                "~/Scripts/jqxpivot.js",
                "~/Scripts/jqxpivotdesigner.js",
                "~/Scripts/jqxpivotgrid.js",
                "~/Scripts/jqxpopover.js",
                "~/Scripts/jqxprogressbar.js",
                "~/Scripts/jqxradiobutton.js",
                "~/Scripts/jqxrangeselector.js",
                "~/Scripts/jqxrating.js",
                "~/Scripts/jqxresponse.js",
                "~/Scripts/jqxresponsivepanel.js",
                "~/Scripts/jqxribbon.js",
                "~/Scripts/jqxscheduler.api.js",
                "~/Scripts/jqxscheduler.js",
                "~/Scripts/jqxscrollbar.js",
                "~/Scripts/jqxscrollview.js",
                "~/Scripts/jqxslider.js",
                "~/Scripts/jqxsortable.js",
                "~/Scripts/jqxsplitter.js",
                "~/Scripts/jqxswitchbutton.js",
                "~/Scripts/jqxtabs.js",
                "~/Scripts/jqxtagcloud.js",
                "~/Scripts/jqxtextarea.js",
                "~/Scripts/jqxtoolbar.js",
                "~/Scripts/jqxtooltip.js",
                "~/Scripts/jqxtouch.js",
                "~/Scripts/jqxtree.js",
                "~/Scripts/jqxtreegrid.js",
                "~/Scripts/jqxtreemap.js",
                "~/Scripts/jqxvalidator.js",
                "~/Scripts/jqxwindow.js"));

            bundles.Add(new ScriptBundle("~/bundles/globalize").Include(
                "~/Scripts/globalize.culture.cs-CZ.js",
                "~/Scripts/globalize.culture.de-DE.js",
                "~/Scripts/globalize.culture.en-CA.js",
                "~/Scripts/globalize.culture.en-US.js",
                "~/Scripts/globalize.culture.fr-FR.js",
                "~/Scripts/globalize.culture.he-IL.js",
                "~/Scripts/globalize.culture.hr-HR.js",
                "~/Scripts/globalize.culture.hu-HU.js",
                "~/Scripts/globalize.culture.it-IT.js",
                "~/Scripts/globalize.culture.ja-JP.js",
                "~/Scripts/globalize.culture.lt.js",
                "~/Scripts/globalize.culture.ru-RU.js",
                "~/Scripts/globalize.culture.sa-IN.js",
                "~/Scripts/globalize.js"));

        }
    }
}
