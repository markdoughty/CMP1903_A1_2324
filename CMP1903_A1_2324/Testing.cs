using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
  internal class Testing {

  //Method
    public void Test() {
      Game game = new Game(); //Create new game object
      List<int> tempList = game.RollDie(); //Make a temp list and assign its value to the return of the game object RollDie method
      int sum = tempList.Sum(); //Make an integer variable, assign its value to be the sum of the items in the list

      Debug.Assert(sum < 19 && sum > 2, "Sum is outside expected range"); //Check to ensure the sum is in the range 3 <= x <= 18
    
      //Check to ensure all rolls are within the valid range
      for (int i = 0; i < tempList.Count; i++) {
        Debug.Assert(tempList[i] > 0 && tempList[i] < 7, "Roll is outside of expected range");
      }
    }
  }
}
