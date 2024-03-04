using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public void Test()
        {
            Game game = new Game();
            var values = game.RunGame();
            Console.WriteLine(values.Item4);
            Debug.Assert(values.Item4 < 19 && values.Item4 > 2, "The sum is incorrect");
            Debug.Assert(values.Item1 < 7 && values.Item1 > 0, "A die roll is invalid");
            Debug.Assert(values.Item2 < 7 && values.Item2 > 0, "A die roll is invalid");
            Debug.Assert(values.Item3 < 7 && values.Item3 > 0, "A die roll is invalid");
        }
    }
}
