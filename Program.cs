Console.WriteLine("Welcome to Employee Wage");
Random rnd = new Random();
int randomcheck = rnd.Next(0, 3);
int fullTime = 0;
int partTime = 1;
int employeeHrs = 0;
int employeeWagePerDay = 0;
int employeeRatePerHr = 20;
if (randomcheck == fullTime)
{
    employeeHrs = 8;
}
else if (randomcheck == partTime)
{
    employeeHrs = 4;
}
else
{
    employeeHrs = 0;
}
employeeWagePerDay = employeeHrs * employeeRatePerHr;
Console.WriteLine("employeeWage = " + employeeWagePerDay);