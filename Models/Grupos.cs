using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IngGasAPI.Models
{
    public class Grupos
    {
        [Key]
        public int gruId { get; set; }
        [Required]
        public string gruCodigo { get; set; }
        [Required(ErrorMessage = "Debe dar el Nombre del Grupo")]
        public string gruNombre { get; set; }
        [Required(ErrorMessage = "Debe dar el Tipo del Grupo")]
        public string gruTipo { get; set; }
        [Required]
        [NotMapped]
        public int usuCreoId { get; set; }
        [Required]
        [NotMapped]
        public DateTime gruFechaCreo { get; set; }
        [NotMapped]
        public int? usuActualizoId { get; set; }
        [NotMapped]
        public DateTime? gruFechaActualizo { get; set; }
    }
}
