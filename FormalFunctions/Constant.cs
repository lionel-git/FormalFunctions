using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalFunctions
{
    public class Constant: Expression
    {
        public string Value { get; set; }

        public Constant(SetType outputType, string value)
        {
            InputTypes = null;
            OutputType = outputType;
            Value = value;
            Name =$"CST_{value}";
        }

        public override string Eval(IList<string> inputs=null)
        {
            if ((inputs != null) && (inputs.Count > 0))
                throw new InvalidArgs(this, inputs);
            return Value;
        }
    }
}
