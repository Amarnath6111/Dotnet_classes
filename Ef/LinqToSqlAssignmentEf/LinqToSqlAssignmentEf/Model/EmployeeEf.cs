using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinqToSqlAssignmentEf.Model
{
    
    class EmployeeEf
    {
        [Key]
        public int Empid { get; set; }
        public string FirstName { get; set; }
        public string LastNmae { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

    }
}
