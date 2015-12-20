using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var cs = ctx.Database.Connection.ConnectionString;

                Student stud = new Student() { StudentName = "New Student",DateOfBirth=DateTime.Now };

                ctx.Students.Add(stud);
                ctx.Resources.Add(new Resource() { Culture = "A", Name = "A", Value = "A" });
                ctx.SaveChanges();
            }
        }
    }
}
