using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { //loop forever unless N pressed
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Roll Again? (Y/N) ");
                Console.ForegroundColor = ConsoleColor.White;
                string RollAgain = Console.ReadLine();
                System.Threading.Thread.Sleep(1);

                //Switch is a way of taking in inputs and doing something with them. AKA guard clause (Making Sure the input is what you want, otherwise Handling It.)
                switch (RollAgain)
                {
                    case "Y": ///If Y is Entered, the Object will be created and the Game will be Carried Out.
                        Game game = new Game();
                        game.Gameloop();
                        System.Threading.Thread.Sleep(1);
                        continue;
                    case "N": ///If N is Entered, The Object will not be created and the Program will Exit.
                        break;
                    default:
                        Console.WriteLine("isn't Valid, please enter Y or N"); //If the wrong character is chosen, the game will not Play or Exit.
                        continue;                                               //Simply make the user aware that this is not a valid response. 
                }
                break;
            }
        }
    }
}
