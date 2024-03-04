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
            Debug.Assert(values.Item4 > 18 || values.Item4 < 3, "The sum is incorrect");
            Debug.Assert(values.Item1 > 6 || values.Item1 < 1, "A die roll is invalid");
            Debug.Assert(values.Item2 > 6 || values.Item2 < 1, "A die roll is invalid");
            Debug.Assert(values.Item3 > 6 || values.Item3 < 1, "A die roll is invalid");
        }
    }
}
