using Microsoft.Reporting.WebForms;
using SSRSTEST.Reports;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SSRSTEST.Controllers
{
    public class ReportScoresController : Controller
    {
        // GET: ReportScores
        public ActionResult Index()
        {
            return View();
        }

        Tech21 ds = new Tech21();
        public ActionResult ReportScore()
        {
            ReportViewer reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
                SizeToReportContent = true,
                Width = Unit.Percentage(900),
                Height = Unit.Percentage(900)
            };



            var connectionString = ConfigurationManager.ConnectionStrings["Tech21ConnectionString"].ConnectionString;


            SqlConnection conx = new SqlConnection(connectionString);

            SqlDataAdapter adp = new SqlDataAdapter("SELECT [UserId], [Score] FROM HighScoreEntries", conx);
            adp.Fill(ds, ds.USP_BrowserTypeCount.TableName);

            reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\TestReport.rdlc";

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Scores", ds.Tables[0]));

            ViewBag.ReportViewer = reportViewer;

            return View();
        }
    }
}