using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalFunctions
{
    public class UnkownFunction : Expression
    {
        public override Expression Eval(IList<Expression> inputs = null)
        {
            return DefaultEval(inputs);
        }
    }
}
