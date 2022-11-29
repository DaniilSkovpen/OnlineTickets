using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorsId { get; set; }

        public string ProfilePicturesURL { get; set; }
        public string FullName { get; set; }
        public string Bios { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
