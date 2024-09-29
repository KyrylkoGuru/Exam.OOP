using MVC_Calc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calc.Controllers
{
    public class AgeController
    {
        public string CheckAgeCategory(int age)
        {
            AgeRevision ageRevision = new AgeRevision(age);
            return ageRevision.GetRevision();
        }
    }
}
