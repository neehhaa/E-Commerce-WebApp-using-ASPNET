using System.ComponentModel.DataAnnotations;

namespace etickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public int Logo { get; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }


    }
}
