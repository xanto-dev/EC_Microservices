using System.ComponentModel.DataAnnotations;

namespace Service_Ressources.Models
{
    public class Ressource
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        public string Description { get; set; }
        [Required]
        public string Type { get; set; } // "Chambre", "Salle", "Evenement"
        [Required]
        public decimal PrixBase { get; set; }
        public bool EstDisponible { get; set; } = true;
    }
}
