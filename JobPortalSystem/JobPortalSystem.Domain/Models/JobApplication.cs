using JobPortalSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
  public class JobApplication
    {

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid JobPostId { get; set; }

        [ForeignKey(nameof(JobPostId))]
        public virtual JobPost JobPost { get; set; } = null!;

        [Required]
        public Guid Applicant { get; set; }

        [ForeignKey(nameof(Applicant))]
        public virtual JobSeeker Seeker { get; set; } = null!;

        [Required]
        public Guid ResumeId { get; set; }

        [ForeignKey(nameof(ResumeId))]
        public virtual Resume Resume { get; set; } = null!;

        [MaxLength(2000)]
        public string? CoverLetter { get; set; }

        [Required]
        public DateTime DateSubmitted { get; set; } = DateTime.UtcNow;

        [Required]
        public Status Status { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}
