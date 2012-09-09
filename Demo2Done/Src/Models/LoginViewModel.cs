using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Src.Models
{
    public class LoginViewModel
    {
        [Display(Name="Brukernavnet ditt her")]
        public string Username { get; set; }

        [DataType(DataType.Password), Display(Name="Skriv inn passordet ditt")]
        public string Password { get; set; }
    }
}