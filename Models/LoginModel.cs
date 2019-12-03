using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AEGEE_MVC.Models
{
    public class LoginModel
    { 

    [Required(ErrorMessage = "Write your Email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Write your Password")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    }
}
