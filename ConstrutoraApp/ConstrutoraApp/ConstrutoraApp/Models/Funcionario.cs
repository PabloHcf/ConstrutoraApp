using System.ComponentModel.DataAnnotations;

namespace ConstrutoraApp.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Cargo { get; set; }
    }
}