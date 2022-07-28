using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieDatabase.Models
{
    public class Media
    {
        public int MediaId { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }

        public string Genre { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public float Rating { get; set; }

        public string Description { get; set; }
    }
}
