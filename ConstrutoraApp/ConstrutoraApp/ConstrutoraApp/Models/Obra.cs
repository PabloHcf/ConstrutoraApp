using System.ComponentModel.DataAnnotations;

namespace ConstrutoraApp.Models
{
    public class Obra
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        public string Endereco { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime? DataFim { get; set; }
    }
}