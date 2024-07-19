using System.ComponentModel.DataAnnotations;

namespace CodeFirstDeneme.Models
{
    public class Araba
    {
        [Key]
        public int Id { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
    }
}
