using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
  public class JobResponsibility
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string? Description { get; set; }

        [Required]
        public Guid JobPostId { get; set; }

        [ForeignKey(nameof(JobPostId))]
        public virtual JobPost JobPostNavigation { get; set; } = null!;
    }
}
