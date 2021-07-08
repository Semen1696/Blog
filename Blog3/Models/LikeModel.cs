using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog3.Models
{
    public class LikeModel
    {
        public int PostId { get; set; }
        public string UserId { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public bool CanLike { get; set;}
        public bool CanDislike { get; set; }

    }
}
