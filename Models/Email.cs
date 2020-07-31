using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolioManagement.Models
{
    public class Email
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Field can't be empty and must email followed by ''@''")]
        public string email { get; set; }
        
        [Required(ErrorMessage = "Field can't be empty")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string password { get; set; }
    }
}