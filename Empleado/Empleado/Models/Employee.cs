using Empleado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public DateTime Birthday { get; set; }
        public string Recomendation { get; set; }
    }
}