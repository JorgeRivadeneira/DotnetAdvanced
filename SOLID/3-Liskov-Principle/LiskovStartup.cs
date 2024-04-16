using SOLID.Liskov;

namespace SOLID.Liskov
{
    public class LiskovStartup
    {
        public LiskovStartup()
        {
            CalculateSalaryMonthly(new List<Employee>() {
                new EmployeeFullTime("Pepito Pérez", 160, 10),
                new EmployeeContractor("Manuel Lopera", 180)
            });
        }
        void CalculateSalaryMonthly(List<Employee> employees)
        {
            foreach (var item in employees)
            {
                decimal salary = item.CalculateSalary();
                Console.WriteLine($"The {item.Fullname}'s salary is {salary}");

            }
        }
    }
}
