using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTickets.Models
{
    public class Produser
    {
        [Key]
        public int ActorsId { get; set; }

        public string ProfilePicturesURL { get; set; }
        public string FullName { get; set; }
        public string Bios { get; set; }
    }
}
