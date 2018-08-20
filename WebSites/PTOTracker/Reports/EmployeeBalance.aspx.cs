using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Reports_EmployeeBalance : System.Web.UI.Page
{
    PTODataEntities db = new PTODataEntities();
    Employee user;
    protected void Page_Load(object sender, EventArgs e)
    {
        user = (Employee)Session["User"];
        List<Employee> employees;
        if (user.IsAdmin())
        {
            employees = db.Employees.ToList();
        }
        else
        {
            employees = db.Employees.Where(emp => emp.EmployeeId == user.EmployeeId).ToList();
        }

        ReportGridView.DataSource = employees;
        ReportGridView.DataBind();

        ReportTitleLabel.Text = "Overall Employee Balance (as of " + DateTime.Today.ToShortDateString() + ")";
    }
}