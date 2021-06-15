using System;
using System.ComponentModel.DataAnnotations;

namespace PC04.Models
{
    public class Fail
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Usuario { get; set; }
        public string[] Comentarios { get; set; }
        public DateTime FechaRegistro { get; set;}

    }
}