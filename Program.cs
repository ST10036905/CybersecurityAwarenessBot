// This is the main entry point of the application. It displays a welcome message to the user.
// Creates object and calls methods that runs the chatbot.
// The code is written in C# and is compatible with .NET 8.0 framework.

using CybersecurityAwarenessBot;

public class Program
{
    public static void Main(string[] args)
    {
        // Display a welcome message to the user calling from consoleUI class
        ConsoleUI consoledata = new ConsoleUI();
        consoledata.DisplayLogo();
    }
}//end of class