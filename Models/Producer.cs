using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BK.Models
{
    public class Producer
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="Profile picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public String FullName { get; set; }
        [Display(Name = "Biography")]
        public String Bio { get; set; }

        //relation

        public List<Movie> Movies { get; set; }
    }
}
