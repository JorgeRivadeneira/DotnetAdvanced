using Xunit;
using DependencyInversion.Controllers;
using Moq;
using DependencyInversion;

namespace Api.Tests;


public class StudentTest 
{
    private Mock<IStudentRepository> _mockStudentRepository;
    private Mock<ILogbook> _mockLogBook;
    private StudentController _studentController;
    public StudentTest()
    {
        _mockStudentRepository = new Mock<IStudentRepository>();
        _mockLogBook = new Mock<ILogbook>();
        _studentController = new StudentController(_mockStudentRepository.Object, _mockLogBook.Object);
    }


    [Fact]
    public void GetStudent()
    {
        _mockStudentRepository.Setup(p => p.GetAll())
                                        .Returns(new List<Student>()
                                        {
                                             new Student(1, "Pepito Pérez", new List<double>() { 3, 4.5 }),
                                             new Student(2, "Mariana Lopera", new List<double>() { 4, 5 }),
                                             new Student(3, "José Molina", new List<double>() { 2, 3 })
                                        });

        var resultGetStudents = _studentController.Get();

        Assert.NotNull(resultGetStudents);
        Assert.Equal(3, resultGetStudents.Count());
    }

    [Fact]
    public void AddStudent_StudentAdded_Success()
    {
        //Arrange
        Student student = new Student()
        {
            Id = 1,
            Fullname = "test",
            Grades = new List<double>() { 10, 10 }
        };
        List<Student> students = new List<Student>();

        //Act
        _mockStudentRepository.Setup(x => x.Add(student));
        _studentController.Add(student);

        //Assert
        Assert.NotNull(_mockStudentRepository.Object);        
        _mockStudentRepository.Verify(p => p.Add(student), Times.Once);
        //_mockLogBook.Verify(l => l.Add($"The student {student.Fullname}"));

    }
}