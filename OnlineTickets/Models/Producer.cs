using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTickets.Models
{
    public class Producer
    {
        [Key]
        public int ActorsId { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePicturesURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Bios")]
        public string Bios { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
