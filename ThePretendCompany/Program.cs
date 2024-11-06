using TCPData;
using TCPExtensions;
using System.Linq;

List<Employee> employeeList = Data.GetEmployees();

//var filteredEmployees = employeeList.Filter(emp => emp.AnnualSalary < 50000);

//foreach (var employee in filteredEmployees)
//{
//    Console.WriteLine($"First Name: {employee.FirstName}");
//    Console.WriteLine($"Last Name: {employee.LastName}");
//    Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
//    Console.WriteLine($"Manager: {employee.IsManager}");
//    Console.WriteLine();
//}


List<Department> departmentList = Data.GetDepartments();

//var filteredDept = departmentList.Filter(dep => dep.ShortName == "HR"  || dep.ShortName == "FN");

//foreach (var department in filteredDept)
//{
//    Console.WriteLine($"Code: {department.ShortName}");
//    Console.WriteLine($"Department: {department.LongName}");
//    Console.WriteLine();
//}

var resultList = from emp in employeeList
                 join dept in departmentList
                 on emp.DepartmentId equals dept.Id
                 select new
                 {
                     Nombre = emp.FirstName,
                     Apellido = emp.LastName,
                     NetoAnual = emp.AnnualSalary,
                     Gerente = emp.IsManager,
                     Departamento = dept.LongName,
                 };

Console.ReadKey();