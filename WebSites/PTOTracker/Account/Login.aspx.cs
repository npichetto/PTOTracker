using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using PTOTracker;

public partial class Account_Login : Page
{
    PTODataEntities db = new PTODataEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
            
    }
            
    protected void LogIn(object sender, EventArgs e)
    {
        int userEmployeeID = Int32.Parse(UserDropDown.SelectedValue);
        Employee user = db.Employees.Find(userEmployeeID);
        Session["User"] = user;
        HttpContext.Current.Response.Redirect("~/Default.aspx");
    }
}