using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AEGEE_MVC.Models
{
    public class RegisterModel
    {

        [Required(ErrorMessage = "Write your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Write your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Repeat the Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Login { get; set; }
     
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Surname { get; set; }

        [DataType(DataType.Text)]
        public int Age { get; set; }
    }
}
