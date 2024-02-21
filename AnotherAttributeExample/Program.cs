using AnotherAttributeExample;
using System.Reflection;

Person person = new Person();
person.Name = "Jhon Smith";
person.Age = 19;

//try
//{
//    person.Name = "Jhon Smith";
//    person.Age = 10;
//}catch(ArgumentOutOfRangeException ex) {
//    Console.WriteLine(ex.Message);
//}

if (!Validator.ValidateAge(person))
{
    Console.WriteLine($"The Age of the user {person.Name} is out of the range: {person.Age}");
}
