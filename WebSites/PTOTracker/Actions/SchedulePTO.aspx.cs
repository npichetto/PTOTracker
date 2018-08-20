using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Actions_SchedulePTO : System.Web.UI.Page
{
    PTODataEntities db = new PTODataEntities();
    Employee user;
    protected void Page_Load(object sender, EventArgs e)
    {
        user = (Employee)Session["User"];
        if (!IsPostBack)
        {
            EmployeeDropDown.SelectedValue = user.EmployeeId.ToString();
            if (!user.IsAdmin())
            {
                EmployeeDropDown.Enabled = false;
            }
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        try
        {
            int employeeID = Int32.Parse(EmployeeDropDown.SelectedValue);
            DateTime startDate = DateTime.Parse(StartDate.Text);
            DateTime endDate = DateTime.Parse(EndDate.Text);
            decimal ptoAmount = Decimal.Parse(PTOAmount.Text);
            if (ptoAmount % 4 != 0 || ptoAmount <= 0)
            {
                PTOAmountValidator.Text = "PTO Amount must be a positive amount in increments of 4.";
                PTOAmountValidator.IsValid = false;
            }
            else if (endDate < startDate)
            {
                EndDateValidator.Text = "End Date must be later than Start Date.";
                EndDateValidator.IsValid = false;
            }
            else if (startDate <= DateTime.Today)
            {
                Employee employee = db.Employees.Single(emp => emp.EmployeeId == employeeID);
                db.SubmitEmployeePTOHistory(employeeID,
                                            ptoAmount * -1,
                                            startDate,
                                            endDate,
                                            Description.Text,
                                            employee.PTOBalance - ptoAmount);
            }
            else
            {
                db.SubmitEmployeeRequest(employeeID,
                                         ptoAmount,
                                         startDate,
                                         endDate,
                                         Description.Text);
            }

            ClearInputs();

            SuccessLabel.ForeColor = System.Drawing.Color.Green;
            SuccessLabel.Text = "Time Off Successfully Added!";
            SuccessLabel.Visible = true;
        }
        catch (Exception ex)
        {
            SuccessLabel.ForeColor = System.Drawing.Color.Red;
            SuccessLabel.Text = "Error Adding Time Off: <br /><t />" + ex.GetType();
            SuccessLabel.Visible = true;
        }
    }

    private void ClearInputs()
    {
        EmployeeDropDown.SelectedValue = user.EmployeeId.ToString();
        StartDate.Text = "";
        EndDate.Text = "";
        PTOAmount.Text = "";
        Description.Text = "";
    }
}