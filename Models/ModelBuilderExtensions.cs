using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Praticeclass.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 101,
                        Name = "Prabhu",
                        Department = Dept.SDE,
                        Email = "prabhu.eva@gmail.com"
                    },
                    new Employee
                    {
                        Id = 102,
                        Name = "Shuvam",
                        Department = Dept.HR,
                        Email = "Shuvam.eva@gmail.com"
                    }
                );
        }
    }
}
