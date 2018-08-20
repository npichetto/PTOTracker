using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EmployeePTOHistory
/// </summary>
public partial class EmployeePTOHistory
{
    public string DateRange
    {
        get
        {
            string dateRange = StartDate.ToShortDateString();
            if (EndDate.ToShortDateString() != StartDate.ToShortDateString())
            {
                dateRange += " - " + EndDate.ToShortDateString();
            }
            return dateRange;
        }
    }
}