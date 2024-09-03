
namespace SOLID.OpenClosed
{
    public class OpenClosedStartup
    {

        /*
         
            CalculateSalaryMonthly(new List<object>() {
                new EmployeeFullTime("Pepito Pérez", 160),
                new EmployeePartTime("Manuel Lopera", 180)
            });


            void CalculateSalaryMonthly(List<object> employees) 
            {
                foreach (var employee in employees)
                {
                    if (employee is EmployeeFullTime) 
                    {
                        decimal hourValue = 30000M;
                        EmployeeFullTime employeeFullTime = ((EmployeeFullTime)employee);
                        decimal salary = hourValue * employeeFullTime.HoursWorked;
                        Console.WriteLine($"Empleado: {employeeFullTime.Fullname}, Pago: {salary:C1} ");
                    }
                    else 
                    {
                        decimal hourValue = 20000M;
                        EmployeePartTime employeePartTime = ((EmployeePartTime)employee);
                        decimal salary = hourValue * employeePartTime.HoursWorked;
                        if (employeePartTime.HoursWorked > 160) {
                            decimal effortCompensation = 5000M;
                            int extraDays = employeePartTime.HoursWorked - 160;
                            salary += effortCompensation * extraDays;
                        }
                        Console.WriteLine($"Empleado: {employeePartTime.Fullname}, Pago: {salary:C1} ");
                    }
                }

            }         

         */
        public OpenClosedStartup()
        {
            ShowSalaryMonthly(new List<Employee>() {
                new EmployeeFullTime("Pepito Pérez", 160),
                new EmployeePartTime("Manuel Lopera", 180),
                new EmployeeContractor("Luisillo", 300)
            });
        }
        void ShowSalaryMonthly(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly()}");
            }

        }
    }
}
