
namespace SOLID.SingleResponsability
{
    public class SingleStartup
    {
        public SingleStartup()
        {
            StudentRepository studentRepository = new StudentRepository();
            ExportHelper exportHelper = new();
            exportHelper.ExportStudents(studentRepository.GetAll());            ;
            Console.WriteLine("Proceso Completado");
        }
    }
}
