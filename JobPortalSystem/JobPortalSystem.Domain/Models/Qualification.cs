using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
   public class Qualification
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        // Foreign Key to JobSeekerProfile
        public Guid? JobseekerProfileId { get; set; }

        // Foreign Key to JobPost
        public Guid? JobPostId { get; set; }

        // Navigation properties
        [ForeignKey(nameof(JobPostId))]
        public virtual JobPost? JobPost { get; set; }

        [ForeignKey(nameof(JobseekerProfileId))]
        public virtual JobSeekerProfile? JobSeekerProfile { get; set; }
    }
}
