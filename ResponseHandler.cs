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


            // Placeholder implementation to ensure all code paths return a value and parameter is used.
            return "I didn't quite understand, could you please rephrase? You can ask me about passwords, suspicious links and safe browsing.";
        }

    }

}//end of class
