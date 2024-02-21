using ExampleAttribute;

var attributes = typeof(AttributeExample).GetCustomAttributes(true);

foreach (var attribute in attributes)
{
    if(attribute is TestAttribute)
    {
        var attValue = (TestAttribute)attribute;
        Console.WriteLine($"Name: {attValue.Name}, Quantity: {attValue.Quantity}");
    }
}