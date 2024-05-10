public static class StringExtensions
{
    public static string Shorten(this string str, int numberOfWords)
    {
        if(numberOfWords < 0) throw new ArgumentOutOfRangeException("Number of words should be greather than or equal to 0");

        if(numberOfWords == 0) return String.Empty;

        var words = str.Split(' ');
        if(words.Length < numberOfWords ) return str;

        return string.Join(" ", words.Take(numberOfWords)) + "...";
    }
}