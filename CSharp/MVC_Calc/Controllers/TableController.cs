using MVC_Calc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calc.Controllers
{

    public class TableController
    {
        public string GetTable(int number)
        {
            Table multiTable = new Table(number);
            return multiTable.CreateTable();
        }
    }
}
