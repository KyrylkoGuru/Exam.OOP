using MVC_Calc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calc.Controllers
{
    public class CalculatorController
    {
        public double PerformOeration(Operation operation)
        {
            return operation.Execute();
        }
    }
}
