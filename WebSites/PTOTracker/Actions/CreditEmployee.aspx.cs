using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Actions_CreditEmployee : System.Web.UI.Page
{
    PTODataEntities db = new PTODataEntities();
    Employee user;
    protected void Page_Load(object sender, EventArgs e)
    {
        user = (Employee)Session["User"];
        if (!user.IsAdmin())
        {
            HttpContext.Current.Response.Redirect("~/Actions/ActionsMain");
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        try
        {
            int employeeID = Int32.Parse(EmployeeDropDown.SelectedValue);
            DateTime startDate = DateTime.Today;
            DateTime endDate = DateTime.Today;
            decimal ptoAmount = Decimal.Parse(PTOAmount.Text);
            Employee employee = db.Employees.Single(emp => emp.EmployeeId == employeeID);
            if (ptoAmount % 4 != 0)
            {
                PTOAmountValidator.Text = "PTO Amount must be in increments of 4.";
                PTOAmountValidator.IsValid = false;
            }
            else
            {
                db.SubmitEmployeePTOHistory(employeeID,
                            ptoAmount,
                            startDate,
                            endDate,
                            Description.Text,
                            employee.PTOBalance + ptoAmount);
            }

            ClearInputs();

            SuccessLabel.ForeColor = System.Drawing.Color.Green;
            SuccessLabel.Text = "Credit Successfully Added!";
            SuccessLabel.Visible = true;
        } catch (Exception ex)
        {
            SuccessLabel.ForeColor = System.Drawing.Color.Red;
            SuccessLabel.Text = "Error Adding Credit: <br /><t />" + ex.GetType();
            SuccessLabel.Visible = true;
        }
    }

    private void ClearInputs()
    {
        PTOAmount.Text = "";
        Description.Text = "";
    }
}