using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Movies
    {
        [Key]
        public int MovieId { set; get; }

        [Required]
        [StringLength(1000)]
        public string Title { set; get; }

        [Required]
        [StringLength(1000)]
        public string SubTitle { set; get; }

        [Required]
        [StringLength(1000)]
        public string Description { set; get; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Year { set; get; }

        [Required]
        [Range(1, 5)]
        public int Rating { set; get; }
    }
}
