using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blog3.Models
{
    public class Posts
    {
        [Key]
        public int PostId { get; set; }
        public string UserId { get; set; }
        public string Author { get; set; }

        [Required]
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Текст записи")]
        public string Text { get; set; }

        [Display(Name = "Титульная картинка")]
        public string TitleImagePath { get; set; }

        public List<Comments> Comments { get; set; }


    }
}
