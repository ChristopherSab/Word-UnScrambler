using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Word_UnScrambler
{
    class Constants
    {
        public const string OptionsOnHowToEnterScrambledWord = "Enter scrambled word(s) manually or as a file: F - filename / M - Manual";
        public const string OptionsOnContinuingTheProgram = "Would You Like To Continue?  Y/N"; 

        public const string EnterScrambledWordsViaFile = "Enter Full Path Including File Name: ";
        public const string EnterScrambledWordsManually = "Enter Word(s) Manually (Separated By Commas If Multiple): ";
        public const string EnterScrambledWordsOptionNotRecognized = "The Option Was Not Recognized.";

        public const string ErrorScrambledWordsCannotBeLoaded = "Scrambled Words Were Not Loaded Because There Was An Error.";
        public const string ErrorProgramWillBeTerminated = "The Program Will Be Terminated.";
                     
        public const string MatchFound = "Match Found For {0}: {1}";
        public const string MatchNotFound = "NO MATCHES HAVE BEEN FOUND";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string wordListFilename = "wordlist.txt";
    }
}
