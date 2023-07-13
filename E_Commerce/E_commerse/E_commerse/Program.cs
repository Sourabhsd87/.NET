// See https://aka.ms/new-console-template for more information
using E_commerse;

Console.WriteLine("Hello, World!");

Dashboard dashboard = new Dashboard();
//Dashboard dashboard1 = new Dashboard(1,"HR",true);

dashboard.financialYear = 2022;
dashboard.disposedValue = true;
dashboard.department = "Sales";

IOrderDetails details = new Dashboard(1, "HR", true);
ICustomerDetails details1 = new Dashboard(2, "Security", false);

details.ShowDetails();
details1.ShowDetails();

