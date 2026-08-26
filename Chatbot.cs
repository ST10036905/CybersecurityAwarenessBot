using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//Mayra Selemane
//Programming practice
//Cybersecurity Awareness Bot Application
namespace CybersecurityAwarenessBot
{
    internal class Chatbot
    {
        /// <summary>
        /// constructor that initializes response handler.
        /// </summary>
        ResponseHandler responses = new ResponseHandler();

        /// <summary>
        /// Creating a method called StartApp that will be used to start the application. 
        /// This method will be responsible for initializing the chatbot and starting the conversation with the user.
        /// </summary>
        public void StartApp()
        {
            // Display a welcome message to the using colors
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Cybersecurity Awareness Assistant!");
            Console.WriteLine("I am here to help you learn about cybersecurity best practices and answer your questions.");
            //ressetting the console color back to default after displaying the welcome message
            Console.ResetColor();
            //calling the method that will handle the audio welcoming the user



            //calling the method that will display the ascii art logo of the application by creating an instance of ConsoleUI class
            ConsoleUI consoledata = new ConsoleUI();
            consoledata.DisplayLogo();



        }//end of StartApp method

        /// <summary>
        /// creating a method called startConversation that is responsible to handle and initiate conversation with user.
        /// prompting the user to enter their name and how they would like to be assisted.
        /// the method will read the user input and display it back to the user.
        /// </summary>
        public void StartConversation()
        {
            //declaring variables that store user name and user input option
            string userName;
            string userInput;

            //prompting the user to enter their name and reading the input from the console
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Please enter your name: ");
            userName = Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(userName + "!" + " Welcome to your chatbot awareness assistant ---");
            Console.WriteLine("How can I assist you today?");

            // Reading the user's question
            userInput = Console.ReadLine();

            // Sending the user's question to the ResponseHandler
            string response = responses.GetResponse(userInput);

            // Displaying the chatbot's response
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bot: " + response);
            Console.ResetColor();

        }

    }
}//end of class
