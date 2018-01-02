using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalFunctions
{
    public class InvalidArgs : Exception
    {
        private string _message;

        public InvalidArgs(Expression e, string message)
        {
            _message = $"Invalid args for expression {e.Name}: {message}";
        }

        public override string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
