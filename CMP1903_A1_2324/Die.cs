using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
  internal class Die {
    private int _dieValue; //Private attribute
    public int DieValue { 
        get => _dieValue; set => _dieValue = value; //Getter and setter methods for encapsulation
    }
    public int Roll() {
        var rand = new Random(); //create new random object
        Thread.Sleep(100); //Pause for a moment to ensure new random numbers are generated
        return rand.Next(1,7); //return an integer from between 1 and 6
    }
  }
}
