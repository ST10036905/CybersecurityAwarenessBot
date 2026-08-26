using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Class responsible for holding the chatbots responses

namespace CybersecurityAwarenessBot
{
    internal class ResponseHandler
    {
        /// <summary>
        /// Processes user question and returns appropiate response.
        /// </summary>
        /// <param name="userInput">The question entered by the user.</param>
        /// <returns>A cybersecurity related response.</returns>
        public string GetResponse(string userInput)
        {
            string input = userInput.ToLower().Trim();

            if( input.Contains("how are you"))
            {
                return "I'm doing great. I'm ready to help you with any cybersecurity related questions.";
            }
            if (input.Contains("what do you do") || input.Contains("purpose"))
            {
                return "I'm here to assist you with any cybersecurity related question, from threats to learning how to stay safe online.";
            }
            if (input.Contains("what can i ask") || input.Contains("what can I ask"))
            {
                return "You can ask me anything about password safety, suspicious links, phishing and safe browsing";
            }
            if (input.Contains("password") || input.Contains("password safety"))
            {
                return "A password should be difficult to guess and should ideally contain a combination of letters, numbers, and symbols and in lenght, 8 characters long";
            }
            if (input.Contains("phishing"))
            {
                return "Phishing is a cyberattack where criminals pretend to be a trustworthy person or organisation to trick you into revealing sensitive information. Be careful with unexpected emails, messages, and links.";
            }

            if (input.Contains("safe browsing") ||
                input.Contains("browse safely") ||
                input.Contains("browsing"))
            {
                return "For safer browsing, use trusted websites, check that the website address is correct, look for HTTPS, avoid suspicious downloads, and keep your browser updated.";
            }

            if (input.Contains("suspicious link") ||
                input.Contains("suspicious links"))
            {
                return "Do not click suspicious links. Check the website address carefully and be especially cautious with shortened URLs or links sent unexpectedly. When in doubt, visit the organisation's official website directly instead.";
            }
            // Placeholder implementation to ensure all code paths return a value and parameter is used.
            return "I didn't quite understand, could you please rephrase? You can ask me about passwords, suspicious links and safe browsing.";
        }//end of method



    }

}//end of class
