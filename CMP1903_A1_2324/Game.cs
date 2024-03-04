using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public (int,int,int,int) RunGame()// RunGame method declared inside of the game class, returns a tuple containing 4 integers
        {
            Die die1 = new Die();// all 3 dice are rolled 
            die1.Roll();
            Thread.Sleep(1);// the sleep function is used because if the random object that is declared is used too soon after each other it will produce the same number for all die
            Die die2 = new Die();
            die2.Roll();
            Thread.Sleep(1);
            Die die3 = new Die();
            die3.Roll();
            Thread.Sleep(1);
            return (die1: die1.Dieval , die2: die2.Dieval, die3: die3.Dieval, sum: die1.Dieval + die2.Dieval + die3.Dieval);// retruns all values in the form (Die1,Die2,Die3,sum of all die)
        }
    }
}
