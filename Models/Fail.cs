using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC04.Models
{
    public class Fail
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string Foto { get; set; }
        [Required]
        public string Usuario { get; set; }
        [NotMapped]
        public string[] Comentarios { get; set; }
        public DateTime FechaRegistro { get; set;}

        public Fail(){
            FechaRegistro = DateTime.Now;
        }
    }
}