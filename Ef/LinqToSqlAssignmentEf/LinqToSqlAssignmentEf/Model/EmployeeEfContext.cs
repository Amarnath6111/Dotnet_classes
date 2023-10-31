using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LinqToSqlAssignmentEf.Model
{
    class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name=EmployeeContext")
        {

        }
        public DbSet<EmployeeEf> EmployeeEfs { get; set; }
    }

}