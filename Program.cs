Console.WriteLine("Welcome to Employee Wage");
int employeeRatePerHr = 20;
int employeeHrs = 0;
int maxWorkingDaysInMonth = 20;
int maxWorkinghrsInMonth = 100;
int totalEmployeeHrs = 0;
int totalWorkingDays = 0;
int isPresent = 0;
int isParttime = 1;

while (totalEmployeeHrs <= maxWorkinghrsInMonth && totalWorkingDays < maxWorkingDaysInMonth)
{
    totalWorkingDays++;
    Random rnd = new Random();
    int employeeCheck = rnd.Next(0, 3);

    if (employeeCheck == isPresent)
    {
        employeeHrs = 8;
    }
    else if (employeeCheck == isParttime)
    {
        employeeHrs = 4;
    }
    else
    {
        employeeHrs = 0;
    }
    totalEmployeeHrs += employeeHrs;
    Console.WriteLine("Day : " + totalWorkingDays + "employeeHours : " + totalEmployeeHrs); 
}
int totalEmployeeWage = totalEmployeeHrs * employeeRatePerHr;
Console.WriteLine("totalWage" + totalEmployeeWage);
