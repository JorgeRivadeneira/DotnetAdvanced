//A variable of type: PrintDelegate
PrintDelegate PrintToConsole = (string text) =>
{
    Console.WriteLine(text);
};
PrintDelegate PrintToFile = (string text) =>
{
    File.AppendAllText("./logs.txt", text);
};

void ConnectToDatabase(PrintDelegate log)
{
    //Do the insertion
    log("Insert a new record into the database.");

    //Insertion Done
    log("The record got inserted into the database");
}

ConnectToDatabase(PrintToConsole);

//The delegate
delegate void PrintDelegate(string text);