using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace start1.Models
{
    public class JournalPage
    {
        public int Id { get; set; }

        public int PageNumber { get; set; }

        [Required]
        public string Content { get; set; }

        public string? ImagePath { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // 🔗 Връзка с Ticket
        public int TicketId { get; set; }

        [ForeignKey("TicketId")]
        public virtual Ticket Ticket { get; set; }

        [NotMapped]
        public bool HasNextPage { get; set; }
    }
}
