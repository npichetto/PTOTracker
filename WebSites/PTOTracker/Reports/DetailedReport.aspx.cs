using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Reports_DetailedReport : System.Web.UI.Page
{
    PTODataEntities db = new PTODataEntities();
    Employee user;
    protected void Page_Load(object sender, EventArgs e)
    {
        user = (Employee)Session["User"];
        if (!IsPostBack)
        {
            EmployeesDropDown.SelectedValue = user.EmployeeId.ToString();
            EmployeesDropDown.Enabled = user.IsAdmin();

            PopulateForm(user);
        }
    }

    private void PopulateForm(Employee employee)
    {
        ReportTitleLabel.Text = "Employee's Detailed Report (as of " + DateTime.Today.ToShortDateString() + ")";
        ReportGridView.DataSource = employee.EmployeePTOHistories.OrderByDescending(hist => hist.EmployeePTOHistoryID);
        ReportGridView.DataBind();
    }

    protected void EmployeesDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        int employeeID = Int32.Parse(EmployeesDropDown.SelectedValue);
        Employee employee = db.Employees.Single(emp => emp.EmployeeId == employeeID);
        PopulateForm(employee);
    }
}