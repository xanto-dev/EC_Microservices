using System.ComponentModel.DataAnnotations;

namespace Service_Reservations.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UtilisateurId { get; set; } // Référence logique vers UserService
        [Required]
        public int RessourceId { get; set; }   // Référence logique vers ResourceService
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Statut { get; set; } = "En attente"; // "Confirmee", "Annulee"
        public decimal MontantTotal { get; set; }
    }
}
