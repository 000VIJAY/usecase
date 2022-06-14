//Console.WriteLine("Welcome to Employee Wage");
int employeeRatePerHr = 20;
int isFulltime = 1;
int employeeWage = 0;
int employeeHrs = 0;
Random rnd = new Random();
int employeeCheck = rnd.Next(0, 2);

if (employeeCheck == isFulltime)
{
    employeeHrs = 8;
}
else
{
    employeeHrs = 0;
}
employeeWage = employeeHrs * employeeRatePerHr;
Console.WriteLine("employeeWagePerDay : " + employeeWage);