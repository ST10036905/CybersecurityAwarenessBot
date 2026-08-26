using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Class : ConsoleUI
// Author : Mayra Selemane
// Date : 2024-19-10
// Description : This class is responsible for handling the console user interface of the Cybersecurity Awareness Bot application.
// It provides methods to display the logo and other UI elements in the console.

namespace CybersecurityAwarenessBot
{
    internal class ConsoleUI
    {
        /// <summary>
        /// method used to display the logo of the Cybersecurity Awareness Assistant in the console.
        /// using ASCII art to create a visually appealing representation of the logo.
        /// </summary>
        public void DisplayLogo()
        {
            //setting text color to cyan for the logo display
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("       M&M CYBERSECURITY AWARENESS ASSISTANT         ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("              __________________                    ");
            Console.WriteLine("             |                  |                   ");
            Console.WriteLine("             |    CYBER SAFE    |                   ");
            Console.WriteLine("             |       [#]        |                   ");
            Console.WriteLine("             |__________________|                   ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            //resetting the console color back to default after displaying the logo
            Console.ResetColor();
            Console.WriteLine();
        }//end of DisplayLogo method
    }

}//end of class
