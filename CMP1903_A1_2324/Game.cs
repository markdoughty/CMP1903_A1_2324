using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
public class Game
{
    private Die[] dice;

    public Game()
    {
        dice = new Die[3]; //Allows the amount of dice that are added to roll
        for (int x = 0; x < 3; x++) //For loop to run the dice rolls until the specified number has been met which is 3 dice
        {
            dice[x] = new Die(); //Creates the Dice object based on the number of times the loop is ran
        }
    }
}
