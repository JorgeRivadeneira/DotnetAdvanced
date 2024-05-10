string post = "This is supossed to be a very long blog post blah blah blah...";
var shortenPost = post.Shorten(5);

IEnumerable<int> numbers = new List<int>() { 1, 3, 5, 10, 2, 18};
var max = numbers.Max();

Console.WriteLine(shortenPost);