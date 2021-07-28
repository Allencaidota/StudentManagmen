﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagmen.Models
{
    //student models
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Name"), MaxLength(50, ErrorMessage ="maximum value for name is 50 charaters")]
        [Required (ErrorMessage = "you need to insert your name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "ClassName")]
        public ClassNameEnum? ClassName { get; set; }

        [Required(ErrorMessage = "you need to insert your Email")]
        [Display(Name ="Email")]
        public string Email { get; set; }

        public string PhotoPath { get; set; }

    }
}
