Console.WriteLine("Welcome to Employee Wage");
Random rnd = new Random();
int num = rnd.Next(0, 2);
int isFullTime = 1;
if (num == isFullTime)
{
    Console.WriteLine("Present");
}
else
    Console.WriteLine("Absent");