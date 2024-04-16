namespace SOLID.Liskov
{
    public class EmployeeFullTime : Employee
    {
        public int ExtraHours { get; set; }

        public EmployeeFullTime(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked)
        {
        }

        public override decimal CalculateSalary()
        {
            decimal hoursValue = 50;
            return hoursValue * (HoursWorked + ExtraHours);
        }
    }
}