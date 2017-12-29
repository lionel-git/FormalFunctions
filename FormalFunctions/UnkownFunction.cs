using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalFunctions
{
    public class UnkownFunction : Expression
    {
        public override string Eval(IList<string> inputs = null)
        {
            return DefaultEval(inputs);
        }
    }
}
