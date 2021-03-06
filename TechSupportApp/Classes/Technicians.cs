﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TechSupportApp.Classes
{
    public class Technicians
    {
        [Key]
        public int TechID { get; set; }

        [Required(ErrorMessage ="Name is required")] 
        public string Name { get; set; }

        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage ="10-digit number is required")]
        public string Phone { get; set; }
    }
}
