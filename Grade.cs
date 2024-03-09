using System;
using System.Linq;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;

namespace Code_First_Assignment
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}