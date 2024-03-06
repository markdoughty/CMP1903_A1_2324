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
        Debug.Assert(Value >= 1 && Value <= 6, "Die roll out of expected range (1-6)."); //Makes sure that it cannot generate a higher or lower number by using debugging
        return Value; //Returns the generated number to the specified die
    }
}
