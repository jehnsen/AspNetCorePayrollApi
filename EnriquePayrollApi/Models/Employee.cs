using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnriquePayrollApi.Models
{
    public class Employee
    {
        public string Id { get; set; }

        public int Firstname { get; set; }
        public int Lastname { get; set; }
        public int Position { get; set; }
    }
}
