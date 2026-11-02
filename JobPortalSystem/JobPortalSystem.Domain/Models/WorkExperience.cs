using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
   public class WorkExperience
    {

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid JobSeekerProfileId { get; set; }

        [Required]
        [MaxLength(100)]
        public string JobTitle { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        public string CompanyName { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string? Summary { get; set; }

        [Required]
        public DateTime ServiceStart { get; set; }

        public DateTime? ServiceEnd { get; set; }

        [ForeignKey(nameof(JobSeekerProfileId))]
        public virtual JobSeekerProfile JobSeekerProfile { get; set; } = null!;
    }
}
