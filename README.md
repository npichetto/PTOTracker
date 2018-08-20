# PTOTracker
**PTOTracker** is a web-based solution for tracking employee PTO. 
As a user, **PTOTracker** allows you to:
 - Log in
 - Request/Schedule time off
 - View your PTO balance
 - View your next scheduled time off
 - View a detailed report of all PTO accruals and expenditures to date
 
As an administrator, **PTOTracker** allows you to do all of the above for any user, as well as:
 - Credit employees discretionary PTO

The system automatically accrues 8 hours of PTO per user per pay period (month).
## Preparation
You must set up your Database Server before you can use **PTOTracker**. To do this:

 1. Attach the provided **PTOData.mdf** and **PTOData.ldf** files (located in ~/DB/) to your Database Server.
 2. Edit the Web.Config file in the root of the PTOTracker project folder. In the **PTODataConnectionString** and **PTODataEntities** connection strings, replace the text "[INSERT SQL CONNECTION STRING HERE]" with the connection string for your Database Server.

### Considerations
1. This project was originally built to be added to an existing employee management system. As such, the login framework is intentionally bare, since the existing system already had desirably robust login functionality. This system only asks that you select a user from a dropdown menu and does not require a password.
2. This project was developed with a pre-determined requirements specification, and as such much of the specification was hard-coded, due to time constraints in development. One example is the client's existing PTO policy, which grants 8 hours of PTO every month. This is fixed and non-configurable.
3. This project is no longer in development. If development is reopened for this project, this document will be updated to reflect any changes to the project.