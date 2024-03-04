using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
  internal class Game {
    //Methods
    public List<int> RollDie() { //New method that returns a list of integers
      List<int> dieResults = new List<int>(); //Create a new list of integers
      Die die; //Create a die variable

      //Rolling the die 3 times
      for (int i = 0; i < 3; i++) {
        die = new Die(); //Create a new die object
        die.DieValue = die.Roll(); //Roll the die, assign the result to the DieValue property
        dieResults.Add(die.DieValue); //Add the die value to the list
      }
      
      return dieResults; //Return the list
    }
  }
}
