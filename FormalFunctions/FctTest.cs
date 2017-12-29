using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalFunctions
{
    // Just a test function
    public class FctTest : Expression
    {
        public override string Eval(IList<string> inputs = null)
        {
            return "titi";
        }
    }
}
