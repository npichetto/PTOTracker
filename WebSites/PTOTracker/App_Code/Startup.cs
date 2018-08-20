using Microsoft.Owin;
using Owin;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;

[assembly: OwinStartupAttribute(typeof(PTOTracker.Startup))]
namespace PTOTracker
{
    public partial class Startup {
        PTODataEntities db = new PTODataEntities();
        public void Configuration(IAppBuilder app) {
            GlobalConfiguration.Configuration.UseSqlServerStorage("PTODataConnectionString");

            app.UseHangfireDashboard();
            app.UseHangfireServer();

            RecurringJob.AddOrUpdate("AutoAccrue", () => AutoAccrue(), Cron.Monthly(1));
            RecurringJob.AddOrUpdate("ConvertRequestsToHistory", () => ConvertRequestsToHistory(), Cron.Daily(8));
        }

        public void AutoAccrue()
        {
            List<Employee> employees = db.Employees.ToList();
            foreach (Employee employee in employees)
            {
                db.AutoAccrual(employee.EmployeeId, employee.PTOBalance + 8);
            }
        }

        public void ConvertRequestsToHistory()
        {
            List<EmployeeRequest> toConvertToday = db.EmployeeRequests.Where(req => req.StartDate == DateTime.Today).ToList();
            foreach (EmployeeRequest request in toConvertToday)
            {
                db.ConvertRequestToHistory(request.Employee.PTOBalance - request.PTOAmount, request.EmployeeRequestId);
            }
        }
    }

}
