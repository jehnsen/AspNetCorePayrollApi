using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnriquePayrollApi.Models
{
    public class Employee
    {
        public string Id { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }
    }
}
