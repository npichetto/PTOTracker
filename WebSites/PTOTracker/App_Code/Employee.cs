using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Employee
/// </summary>
public partial class Employee
{
    public bool IsAdmin()
    {
        return 1 == EmployeeRoleId;
    }

    public string NextPTOEventString
    {
        get
        {
            EmployeeRequest nextRequest = GetNextRequest();
            if (null == nextRequest) return "[none]";

            return nextRequest.DateRange + ": " +
                   nextRequest.PTOAmount + " hours (" +
                   nextRequest.Description + ")";
        }
    }

    public string BalanceHours
    {
        get
        {
            return PTOBalance.ToString() + " hours"; 
        }
    }

    public decimal PTOBalance
    {
        get
        {
            if (EmployeePTOHistories.Count > 0)
                return EmployeePTOHistories.OrderByDescending(hist => hist.StartDate).First().ResultingPTOBalance;
            return 0;
        }
    }

    private EmployeeRequest GetNextRequest()
    {
        if (EmployeeRequests.Count() > 0)
        {
            return EmployeeRequests.OrderBy(act => act.StartDate).First();
        }

        return null;
                              
    }
}