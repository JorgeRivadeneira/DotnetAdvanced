using Attributes;
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
Console.WriteLine(assembly.FullName);


var typesAs = assembly.GetTypes();
foreach (var type in typesAs)
{
    Console.WriteLine("Type: " +  type.Name);
    var props = type.GetProperties();
    foreach (var prop in props)
    {
        Console.WriteLine("\tProperty: " +  prop.Name + " Property Type: " + prop.PropertyType);
    }

    var fields = type.GetFields();
    foreach (var field in fields)
    {
        Console.WriteLine("\tField: " + field.Name);
    }

}


var types = from t in Assembly.GetExecutingAssembly().GetTypes()
            where t.GetCustomAttributes<SampleAttribute>().Count() > 0
            select t;

foreach (var t in types)
{
    Console.WriteLine(t.Name);
}