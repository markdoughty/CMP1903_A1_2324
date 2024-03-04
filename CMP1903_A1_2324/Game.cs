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
        public (int,int,int,int) RunGame()
        {
            Die die1 = new Die();
            int value1 = die1.Roll();
            Thread.Sleep(1);
            Die die2 = new Die();
            int value2 = die2.Roll();
            Thread.Sleep(1);
            Die die3 = new Die();
            int value3 = die3.Roll();
            Thread.Sleep(1);
            return (die1: die1.Dieval , die2: die2.Dieval, die3: die3.Dieval, sum: die1.Dieval + die2.Dieval + die3.Dieval);
        }
    }
}
