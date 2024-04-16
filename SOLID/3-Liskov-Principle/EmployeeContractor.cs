namespace SOLID.Liskov
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked) : base(fullname, hoursWorked)
        {
        }

        public override decimal CalculateSalary()
        {
            decimal hoursValue = 40;
            return hoursValue * (HoursWorked);
        }
    }
}