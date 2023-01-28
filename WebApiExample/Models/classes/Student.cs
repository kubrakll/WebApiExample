using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiExample.Models.classes
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Please enter name !")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Please enter surname !")]
        public string StudentSurname { get; set; }


        public bool StudentStatus { get; set; }
    }
}