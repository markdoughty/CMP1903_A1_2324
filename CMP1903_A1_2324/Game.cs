using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
//using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
    internal class Game {
        /// <value>
        /// "die1", "die2" and "die3" are all instantiations of the dice this program will use to simulate dice rolls
        /// </value>
        private Die _die1;
        private Die _die2;
        private Die _die3;
        /// <summary>
        /// Constructor initialises game with 3 dice
        /// </summary>
        public Game() {
            _die1 = new Die();
            _die2 = new Die();
            _die3 = new Die();
        }
        /// <summary>
        /// Allows external code to see the value of die 1, while also specifically not allowing 
        /// them to set/tamper with the value of that die, protecting it so that its value is can
        /// only determined by the methods in this class
        /// </summary>
        /// <returns>
        /// Returns the value of die 1 (an interager between 1 and 6)
        /// </returns>
        public int Die1 {
            get {
                return _die1.Value;
            }
        }
        /// <summary>
        /// Allows external code to see the value of die 2, while also specifically not allowing 
        /// them to set/tamper with the value of that die, protecting it so that its value is can
        /// only determined by the methods in this class
        /// </summary>
        /// <returns>
        /// Returns the value of die 2 (an interager between 1 and 6)
        /// </returns>
        public int Die2 {
            get {
                return _die2.Value;
            }
        }
        /// <summary>
        /// Allows external code to see the value of die 3, while also specifically not allowing 
        /// them to set/tamper with the value of that die, protecting it so that its value is can
        /// only determined by the methods in this class
        /// </summary>
        /// <returns>
        /// Returns the value of die 3 (an interager between 1 and 6)
        /// </returns>
        public int Die3 {
            get {
                return _die3.Value;
            }
        }
        /// <summary>
        /// Method rolls three die objects and returns the sum
        /// </summary>
        /// <returns>
        /// Returns the sum of the 3 dice rolls (an intager between 3 and 18)
        /// </returns>
        public int Play() {
            int sum=0;
            sum += _die1.Roll();                    // roll all the 3 dice
            sum += _die2.Roll();
            sum += _die3.Roll();
            // prints out all individual dice rolls
            Console.WriteLine($"Dice 1 rolled {_die1.Value}");
            Console.WriteLine($"Dice 2 rolled {_die2.Value}");
            Console.WriteLine($"Dice 3 rolled {_die3.Value}");
            // prints out the sum of the dice rolls
            Console.WriteLine("Rolled 3 dice, total was "+sum);
            return sum;
        }
        /// <summary>
        /// Method continually executes "Play()" (see <see cref="Play"/> ) until the user specifies
        /// to stop.
        /// </summary>
        public void PlayContinuous() {
            while (true) {                          // this method eternally repeats until the user
                                                    // responds "no" and the if statement seen at
                                                    // the end of this method will exit the Method 
                Play();                             // 1. do "Play()"
                Console.WriteLine("Do you want to roll again?");
                string reply;
                while (true) {                      // 2. will eternally ask the user util they
                                                    // give a valid answer
                    try {
                        reply = _RespondYesOrNo();
                        break;
                    }
                    catch (ArgumentException ex) {  // if the reply is invalid, then
                                                    // "_RespondYesOrNo()" will pull an
                                                    // ArgumentException before "break" is run
                        Console.WriteLine(ex.Message);
                    }
                }
                if (reply == "no") {                // 3. if user responded "no", then exit this
                                                    // function
                    return;
                }
                                                    // else do nothing (and this forever loop is
                                                    // repeated)
            }
        }
        /// <summary>
        /// This private method asks the use to respond to a yes/no question and will return "yes",
        /// "no" or an "ArgumentException" if the responce can't be rounded to either of these
        /// answers.
        /// </summary>
        /// <returns>
        /// Rounds up the user's answer to "yes" or "no" and returns "yes" or "no"
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Will raise an "ArgumentException" if the input isn't "n", "y", "no" or "yes"
        /// </exception>
        private string _RespondYesOrNo() {
            string reply = Console.ReadLine();      // get response from user
            if (reply == string.Empty) {            // throw an error if they give no reply
                throw new ArgumentException("ERROR: Please give an input");
            }
            reply = reply.Trim();                   // Cleans the input (reply) by removing any
                                                    // white spaces before and after the input
            reply = reply.ToLower();                // Converts reply string to lower case letters
                                                    // to simplify the coming "if" statements
            if (                                    // if responce can be rounded to "yes" then
                reply == "y" ||                     // return "yes"
                reply == "yes"
                ) {
                return "yes";
            }
            else if (                               // if responce can be rounded to "no" then
                reply == "n" ||                     // return "no"
                reply == "no"
                ) {
                return "no";
            }
            else {                                  // else it couldn't be rounded to anything, so
                                                    // return/throw an error
                throw new ArgumentException("ERROR: Please input \"yes\" or \"no\"");
            }
        }
    }
}
