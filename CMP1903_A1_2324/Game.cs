using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Game{
        
        private Die[] dice;
        private int num_Dice;

        public Game(int num_Dice){
            
            this.num_Dice = num_Dice;
            dice = new Die[num_Dice]; //Sets dice equal to total num of die set
            for (int x = 0; x < num_Dice; x++) //loops rolling dice for the specified number of times{
            
                dice[x] = new Die(); //Creates the dice objects
        }
    }
}
