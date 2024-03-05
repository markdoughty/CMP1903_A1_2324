using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Game run= new Game();
            
            run.Start();//initial games
            
            
            Testing test = new Testing();
            test.GameTest();// testing the game and Die
            Console.WriteLine(" ");

            // <black-eye-inc> Summary of entire review:
            // "Program.cs" functions perfectly fine and flawlessly -- well done!
            // all commenting is great -- neither over explaining or under explaining how the code works
            // Other than the missing EXTRA Funtionality requirement of being able to "continuously roll the dice" in "Game.cs"
            // and the dodgy "Debug.Assert()" statement in "Testing.cs" I'd say this program meets all required criteria
            // mentioned in the brief.
            // Keep up the good work and I have full faith you'll pass Computer Science!

            // Overall a great compliance with the C# style guide's naming rules (e.g: using PascalCase for all method names),
            // with only one slip-up with "HoldValue" in "Die.cs".
            // Here's the URL for the  C# Style Guide encase you want it: https://google.github.io/styleguide/csharp-style.html
            // that said, few of the other rules specified by the C# style guide were followed,
            // For example
            // - all comments must start at column 53 ("Col 53") and go
                                                    // something like this, continuing on the next
                                                    // line every time you reach column 100
            // - There must be an indent after the namespace
            // - and many more small petty things I personally won't bother with and with settle for a "2:1 pass"

            // I haven't found XML Documentation in your code, although it is only manditory/uselful if you want the top marks
            // Here's a URL to the XML Documentation and how to use it: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
            // </black-eye-inc>
        }
    }
}
