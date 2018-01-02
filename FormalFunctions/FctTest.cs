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
        public override Expression Eval(IList<Expression> inputs = null)
        {
            var f = new FctSum();
            f.InputTypes = new List<SetType>() { SetType.Reals, SetType.Reals };
            f.OutputType = SetType.Reals;
            f.Name = "SumTest";
            return f;
        }
    }
}
