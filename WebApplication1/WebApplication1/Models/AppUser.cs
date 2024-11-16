using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RunGroopWebApp.Models
{
    public class AppUser : IdentityUser
    {
        [Key]
        public string Id { get; set; }
        public int? Pace { get; set; }
        //int?它可以是整数，也可以为空null
        public int? Mileage { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address? Address { get; set; }
        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }

    }
}
