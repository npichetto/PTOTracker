using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Actions_Actions : System.Web.UI.Page
{
    private Employee user;
    protected void Page_Load(object sender, EventArgs e)
    {
        user = (Employee)Session["User"];
        if (!user.IsAdmin())
        {
            CreditEmployeeButton.Visible = false;
        }
    }
    
}