using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalFunctions
{
    public class Variable : Expression
    {
        public Variable(SetType outputType, string name)
        {
            InputTypes = new List<SetType> { outputType };
            OutputType = outputType;
            Name = name;
        }

        public override string Eval(IList<string> inputs = null)
        {
            return Name;
        }
    }
}
