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

        public override Expression Eval(IList<Expression> inputs=null)
        {
            CheckInputs(inputs);
            return this;
        }

        public override string ToStr(IList<Expression> inputs = null)
        {
            return $"{Value}";
        }
    }
}
