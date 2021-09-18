using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BK.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Pro Pic")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public String FullName { get; set; }
        [Display(Name = "Biography")]
        public String Bio { get; set; }

        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
