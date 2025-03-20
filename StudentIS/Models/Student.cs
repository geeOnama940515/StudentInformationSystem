using System;
using System.ComponentModel.DataAnnotations;

namespace StudentIS.Models;

public class Student
{
         [Key]
         public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public int GradeLevel { get; set; }

        [Required]
        public string Section { get; set; }

        [Phone]
        public string ContactNumber { get; set; }
}
