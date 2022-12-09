using System.ComponentModel.DataAnnotations;

namespace etickets.Models
{
    public class Actor
    {
        [Key]
        public string Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        public List<Actor_Movie> Actor_Movies { get; set; }

    }
}
