using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalFunctions
{
    public class Expression
    {
        // Functions with 0 inputs are constantes
        public IList<SetType> InputTypes { get; set; }
        public SetType OutputType { get; set; }
        public string Name { get; set; }

        public int CheckInputs(IList<Expression> inputs)
        {
            int nbInputs = (inputs != null ? inputs.Count : 0);
            if (nbInputs != InputTypes.Count)
                throw new InvalidArgs(this, $"Invalid arg count, expected {nbInputs}, got {inputs.Count}");
            return nbInputs;
        }

        public Expression DefaultEval(IList<Expression> inputs)
        {
            int nbInputs = CheckInputs(inputs);
            return this;
        }

        public virtual Expression Eval(IList<Expression> inputs = null)
        {
            return DefaultEval(inputs);
        }

        public virtual string ToStr(IList<Expression> inputs=null)
        {
            int nbInputs = CheckInputs(inputs);
            var sb = new StringBuilder();
            sb.Append(Name).Append("(");
            for (int i = 0; i < nbInputs; i++)
            {
                if (i > 0)
                    sb.Append(", ");
                sb.Append(inputs[i].ToStr());
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}
