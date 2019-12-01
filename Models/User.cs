using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AEGEE_MVC.Models
{
    public class User
    {
        [Required]
        public int UserId { get; set;}

        [Required]
        [DataType(DataType.Text)]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Surname { get; set; }

        [DataType(DataType.Text)]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //[DataType(DataType.Text)]
        //public string Image { get; set; }

        //public string Rights { get; set; }

        [ScaffoldColumn(false)]
        [BindNever]
        public List<Descriptions> Descriptions { get; set; }
    }
}
