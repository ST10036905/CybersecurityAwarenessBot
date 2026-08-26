using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; //importing 
//Class responsible for handling the voice greeting audio

namespace CybersecurityAwarenessBot
{
    internal class VoiceGreeting
    {
        /// <summary>
        /// importing windows ddl file that handles the media functionality.
        /// </summary>
        /// <param name="pszSound"></param>
        /// <param name="hmod"></param>
        /// <param name="fdwSound"></param>
        /// <returns></returns>
        [DllImport("winmm.dll")]
        //calling an external method from outside c#.
        private static extern bool PlaySound(
        string pszSound,
        IntPtr hmod,
        uint fdwSound);
        //constants to define how the sound should be played
        private const uint SND_FILENAME = 0x00020000;
        private const uint SND_ASYNC = 0x0001;

        /// <summary>
        /// Plays the default voice greeting audio file if it is available.
        /// </summary>
        /// <remarks>The method searches for a file named "voice_greeting.wav" in the "Audio" subdirectory
        /// of the application's base directory. If the file is not found, a message is written to the console and no
        /// audio is played.</remarks>
        public void PlayGreeting()
        {
            //searched the audio in base directory "folder/audio"
            string audioPath = Path.Combine(
                AppContext.BaseDirectory,
                "Audio",
                "voice_greeting.wav");
            //if statement to lookup if the file exists
            if (File.Exists(audioPath))
            {
                //if file exists, play the sound using the constants declared
                PlaySound(
                    audioPath,
                    IntPtr.Zero,
                    SND_FILENAME | SND_ASYNC);
            }
            else
            {
                Console.WriteLine("Voice greeting could not be found.");
            }
        }
    }
}//end of class
