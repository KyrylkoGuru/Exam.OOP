using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calc.Models
{
    public abstract class Operation
    {
        protected double Num1 {  get; set; }
        protected double Num2 { get; set; }
        public Operation(double num1, double num2) 
        {
            Num1 = num1;
            Num2 = num2;
        }
        public abstract double Execute();
    }
}
