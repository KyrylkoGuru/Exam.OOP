using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calc.Models
{
    public class Mulriplication : Operation
    {
        public Mulriplication(double num1, double num2)
            : base(num1, num2)
        {

        }
        public override double Execute()
        {
            return Num1 * Num2;
        }
    }
}
