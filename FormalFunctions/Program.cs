using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var e = new Expression();
                e.Name = "P";
                e.InputTypes = new List<SetType>() { SetType.Reals, SetType.Reals };
                e.OutputType = SetType.Reals;

                var z = new Constant(SetType.Reals, "2.1");

                var r = e.Eval(new List<Expression>() { z, z });
                Console.WriteLine(r);

                Console.WriteLine(e.ToStr(new List<Expression>() { z, z }));

                //var r2 = e.Eval(new List<Expression>() { "1", "2", "3" });
                //Console.WriteLine(r2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
