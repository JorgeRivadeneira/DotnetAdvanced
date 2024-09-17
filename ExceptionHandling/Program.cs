using ExceptionHandling;

try
{
    //using(var sr = new StreamReader(@"C:\file.zip"))
    //{
    //    var content = sr.ReadToEnd();
    //}

    //var calculator = new Calculator();
    //var result = calculator.Divide(5, 0);

    var api = new YouTubeAPI();
    var videos = api.GetVideos("Jorge");
}
catch(DivideByZeroException zeroEx)
{
    Console.WriteLine($"Zero: {zeroEx.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"General: {ex.Message}");
}
