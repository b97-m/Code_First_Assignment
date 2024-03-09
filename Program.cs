using System;
using System.Linq;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;

namespace Code_First_Assignment
{
     public class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.Write("Student saved successfully");
            }
        }
    }
}