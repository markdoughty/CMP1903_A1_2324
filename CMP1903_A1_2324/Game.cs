using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903_A1_2324
{
    internal class Game
    {
     
        
        Die myDie1 = new Die();
        Die myDie2 = new Die();
        Die myDie3 = new Die();


        public int count()
            
        {
            int rollValue1 = myDie1.Roll();
            int rollValue2 = myDie2.Roll();
            int rollValue3 = myDie3.Roll();

            int total = rollValue1 + rollValue2 + rollValue3;
            
            return total;
            

        }    


            
        

       
    }


        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
    }

    
