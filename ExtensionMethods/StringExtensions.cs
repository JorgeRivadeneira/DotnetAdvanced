public static class StringExtensions
{
    //Tiene que ser static, tanto la clase como el método y del primer parámetro tiene que iniciar con this + el tipo de dato, en éste caso es string
    public static string Shorten(this string str, int numberOfWords)
    {
        if(numberOfWords < 0) throw new ArgumentOutOfRangeException("Number of words should be greather than or equal to 0");

        if(numberOfWords == 0) return String.Empty;

        var words = str.Split(' ');
        List<string> capitalizedWords = new List<string>();
        if(words.Length < numberOfWords ) return str;

        foreach( var word in words)
        {
            capitalizedWords.Add(word.Substring(0,1).ToUpper() + word.Substring(1));
        }

        return string.Join(" ", capitalizedWords.Take(numberOfWords)) + "...";
    }
}