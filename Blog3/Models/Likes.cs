using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blog3.Models
{
    public class Likes
    {
        [Key]
        public int LikeId { get; set; }
        public string UserId { get; set; }       
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        public int PostId { get; set; }
        public Posts Post { get; set; }
    }
}
