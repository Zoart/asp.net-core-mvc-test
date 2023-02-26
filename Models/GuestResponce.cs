using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace study.Models
{
    public class GuestResponce
    {
       [Required(ErrorMessage = "Please enter your name")]
       public string Name { get; set; }
       [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
       public string Email { get; set; }
       [Required(ErrorMessage = "Pleacle enter your phone number")]
       public string Phone { get; set; }
       [Required(ErrorMessage = "Pleace specify whether you'll attend")]
       public bool? WillAttend { get; set; }
    }
}