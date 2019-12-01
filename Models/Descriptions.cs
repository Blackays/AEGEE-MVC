using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AEGEE_MVC.Models
{
    public class Descriptions
    {
        [Key]
        [BindNever]
        public int DescId { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]   
        public virtual User UserCharacterId { get; set; }

        [Required]        
        public int UserAuthorId { get; set; }
    }
}
