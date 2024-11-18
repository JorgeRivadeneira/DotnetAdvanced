const string directoryPath = @"C:\flutter";

DisplayDirectoriesInDirectory(directoryPath, 1);



static void DisplayDirectoriesInDirectory(string path, int depth = 0)
{

    string[] directories = Directory.GetDirectories(path);

    foreach (string directory in directories)
    {
        Console.WriteLine(directory);
        if(depth > 0)
        {
            DisplayDirectoriesInDirectory(directory, depth - 1);
        }
    }
}
