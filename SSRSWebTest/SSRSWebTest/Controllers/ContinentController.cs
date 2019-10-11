using Microsoft.Reporting.WebForms;
using SSRSWebTest.Reports;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ReportViewerMVC5.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee  
        public ActionResult Index()
        {
            return View();
        }

        World ds = new World();
        public ActionResult ReportContinent()
        {

            ReportViewer reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
                SizeToReportContent = true,
                Width = Unit.Percentage(900),
                Height = Unit.Percentage(900)
            };
            var connectionString = ConfigurationManager.ConnectionStrings["WorldConnectionString"].ConnectionString;


            SqlConnection conx = new SqlConnection(connectionString); SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Continents", conx);

            adp.Fill(ds, ds.Continents.TableName);

            reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\Continents.rdlc";
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("World", ds.Tables[0]));


            ViewBag.ReportViewer = reportViewer;

            return View();
        }
    }
}