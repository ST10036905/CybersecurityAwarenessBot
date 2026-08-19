// This is the main entry point of the application. It displays a welcome message to the user.
// Creates object and calls methods that runs the chatbot.
// The code is written in C# and is compatible with .NET 8.0 framework.

using CybersecurityAwarenessBot;

public class Program
{
    public static void Main(string[] args)
    {
        // Starting up the chatbot application by creating an instance of the Chatbot class and calling startApp method.
        Chatbot chatbot = new Chatbot();
        chatbot.StartApp();
        //calling method that initiates conversation with the user. 
        chatbot.StartConversation();
    }
}//end of class