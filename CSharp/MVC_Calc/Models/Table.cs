using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calc.Models
{
    public class Table
    {
        public int Number { get; set; }

        public Table(int number)
        {
            Number = number;
        }

        public string CreateTable()
        {
            string table = "";
            for (int i = 1; i <= 10; i++)
            {
                table += $"{Number} x {i} = {Number * i}\n";
            }
            return table;
        }
    }
}
