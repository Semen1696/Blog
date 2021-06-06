using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog3.Models
{
    public class Comments
    {
        [Key]
        public int CommId { get; set; }

        [Required]
        [Display(Name = "Комментарий")]
        public string Text { get; set; }       
        public string Author { get; set; }
        public int PostId { get; set; }
        public string UserId { get; set; }
        public Posts Post { get; set; }

    }
}
