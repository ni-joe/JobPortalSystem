using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
   public class SavedJob
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid Job { get; set; }

        [ForeignKey(nameof(Job))]
        public virtual JobPost JobPost { get; set; } = null!;

        [Required]
        public Guid SavedBy { get; set; }

        [ForeignKey(nameof(SavedBy))]
        public virtual JobSeeker JobSeeker { get; set; } = null!;

        [Required]
        public DateTime DateSaved { get; set; } = DateTime.UtcNow;
    }
}
