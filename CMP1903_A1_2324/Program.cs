using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
  internal class Program {
    static void Main(string[] args) {
      Testing testing = new Testing();

      testing.Test();

      Game game = new Game();

      List<int> tempList = game.RollDie();

      for (int i = 0; i < tempList.Count; i++){
        Console.WriteLine("Roll " + (i+1) + " is " + tempList[i]);
      }
      Console.WriteLine("Sum of the rolls is: " + tempList.Sum());
    }
  }
}
