using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
   public class JobSeeker
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid SystemUserId { get; set; }

        public virtual SystemUser? SystemUser { get; set; }

        // Job seeker role
        public Enums.Role? Role { get; set; }

        // Profile image
        public byte[]? Image { get; set; }

        public virtual ICollection<JobApplication> JobApplications
        { get; set; } = new List<JobApplication>();

        public virtual ICollection<SavedJob> SavedJobs
        { get; set; } = new List<SavedJob>();

        public virtual ICollection<Interview> Interviews
        { get; set; } = new List<Interview>();

        public virtual ICollection<JobSeekerProfile> JobSeekerProfiles
        { get; set; } = new List<JobSeekerProfile>();
    }
}
