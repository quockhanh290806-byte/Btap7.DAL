using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.DAL.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

    }
}
