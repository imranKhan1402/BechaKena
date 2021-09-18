using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BK.Models
{
    public class Cinema
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="Cinema")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        public String Name { get; set; }
        [Display(Name = "Cinema Details")]
        public String Description { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
