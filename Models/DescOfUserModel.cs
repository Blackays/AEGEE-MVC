using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AEGEE_MVC.Models
{
    public class DescOfUserModel
    {

        public IEnumerable<Descriptions> Desc { get; set; }                          

        public int UserId { get; set; }

        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        public string Surname { get; set; }

    }
}
