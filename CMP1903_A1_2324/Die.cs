using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Die
{
    private static Random random = new Random(); //Sets random as a new random in order to roll a number from 1-6 randomly
    public int Value { get; private set; } //Sets a new integer value for the dice to store the random number

    public int Roll()
    {
        Value = random.Next(1, 7); //Generates random number between 1-6 with 6 included
        return Value; //Returns the generated number to the specified die
    }
}
