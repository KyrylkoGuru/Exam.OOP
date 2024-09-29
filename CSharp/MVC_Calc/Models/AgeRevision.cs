using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calc.Models
{
    internal class AgeRevision
    {
        public int Age { get; set; }
        public AgeRevision(int age)
        {
            Age = age;
        }
        public string GetRevision()
        {
            if (Age <= 13)
                return "Дитина";
            else if (Age <= 18)
                return "Підліток";
            else if (Age <= 65)
                return "Дорослий/ла";
            else return "Пенсіонер/ка";
        }
    }
}
