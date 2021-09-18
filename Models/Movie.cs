using BK.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BK.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="Movie Name")]
        public string Name { get; set; }
        [Display(Name = "Movie Details")]
        public String Description { get; set; }
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Display(Name = "Movie")]
        public String ImageURL { get; set; }
        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Movie Category")]
        public MovieCategory MovieCategory { get; set; }
        public string CinemaName { get; set; }

        public List<Actor_Movie> Actor_Movies { get; set; }
        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]
        public Cinema Cinema { get; set; }

        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public Producer Producer { get; set; }


    }
}
