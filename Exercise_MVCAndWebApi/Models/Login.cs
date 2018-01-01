using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise_MVCAndWebApi.Models
{
    public class Login
    {
        [DisplayName("Account")]
        [Required(ErrorMessage = "Account Is Blank")]
        public string Account { get; set; }


        [DisplayName("Password")]
        [Required(ErrorMessage = "Password Is Blank")]        
        public string Password { get; set; }
    }
}