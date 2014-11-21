using EFDemo1.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;

namespace EFDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EFDempContext())
            {
                db.Database.Log = s => Console.WriteLine(s);
                //Select
                //Lazy Load
                var employeeLazy = db.employees.ToList();
                foreach (var e in employeeLazy)
                {
                    Console.WriteLine("{0}: {1}", e.empName, e.department.depName);
                }
                //Eager Fetch
                var employeeEager = db.employees.Include("Department").ToList();
                foreach (var e in employeeEager)
                {
                    Console.WriteLine("{0}: {1}", e.empName, e.department.depName);
                }


                // Create
                //Console.Write("Enter a name for a new Department: ");
                //var name = Console.ReadLine();
                //var department = new Department();
                //department.depName = "RD";
                //db.departments.Add(department);
                //db.SaveChanges();

                //Update
                //Console.Write("Change Department");
                //var department = from d in db.departments
                //                  where d.depId == 1
                //                  select d;

                //department.Single().depName = "Management";
                //db.SaveChanges();

                //Delete 
                //var department = new Department { depId = 1 };
                //db.departments.Attach(department);
                //db.departments.Remove(department);
                //db.SaveChanges();

            }
        }
    }
}
