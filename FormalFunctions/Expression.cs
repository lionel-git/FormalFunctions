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

        public int CheckInputs(IList<string> inputs)
        {
            int nbInputs = (inputs != null ? inputs.Count : 0);
            if (nbInputs != InputTypes.Count)
                throw new InvalidArgs(this, inputs);
            return nbInputs;
        }

        public string DefaultEval(IList<string> inputs)
        {
            int nbInputs = CheckInputs(inputs);
            var sb = new StringBuilder();
            sb.Append(Name).Append("(");
            for (int i = 0; i < nbInputs; i++)
            {
                if (i > 0)
                    sb.Append(", ");
                sb.Append(inputs[i]);
            }
            sb.Append(")");
            return sb.ToString();
        }

        public virtual string Eval(IList<string> inputs = null)
        {
            return DefaultEval(inputs);
        }
    }
}
