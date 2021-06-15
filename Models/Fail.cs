using System.ComponentModel.DataAnnotations;

namespace PC04.Models
{
    public class Fail
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string Usuario { get; set; }

    }
}