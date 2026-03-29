using System.ComponentModel.DataAnnotations;

namespace Service_Notifications.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ReservationId { get; set; } // Référence à la réservation concernée 

        [Required]
        public string Destinataire { get; set; } // Email ou numéro de téléphone de l'utilisateur

        [Required]
        public string Sujet { get; set; } // ex: "Confirmation de votre réservation"

        [Required]
        public string CorpsMessage { get; set; } // Le contenu du message (HTML ou texte)

        [Required]
        public string Type { get; set; } // "Email" ou "SMS" 

        public DateTime DateEnvoi { get; set; } = DateTime.UtcNow;

        [Required]
        public string Statut { get; set; } // "Envoyé", "Échoué", "En attente"
    }
}
