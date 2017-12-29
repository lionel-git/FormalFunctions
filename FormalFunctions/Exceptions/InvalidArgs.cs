using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalFunctions
{
    public class InvalidArgs : Exception
    {
        private Expression _expression;
        private IList<string> _inputs;

        public InvalidArgs(Expression e, IList<string> inputs)
        {
            _expression = e;
            _inputs = inputs;
        }

        public override string Message
        {
            get
            {
                int nbInputs = (_inputs != null ? _inputs.Count : 0);
                return $"Invalid args for expression: {_expression.Name} ({_expression.InputTypes.Count} <> {nbInputs})";
            }
        }
    }
}
