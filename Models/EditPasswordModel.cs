using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AEGEE_MVC.Models
{
    public class EditPasswordModel
    {
        [Required]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Password is wrong")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "Write New Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Repeat the Password")]
        public string ConfirmPassword { get; set; }
    }
}
