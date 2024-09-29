using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calc.Models
{
    public class Division : Operation
    {
        public Division(double operand1, double operand2)
            : base(operand1, operand2)
        {

        }
        public override double Execute()
        {
            if (Num2 == 0) 
            throw new DivideByZeroException("Error: Division by zero!");
            return Num1 / Num2; 
        }
    }
}
