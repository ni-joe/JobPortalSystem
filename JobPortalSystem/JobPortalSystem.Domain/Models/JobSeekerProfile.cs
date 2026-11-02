using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace JobPortalSystem.Domain.Models
{
 public class JobSeekerProfile
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        // Foreign Key to Resume (optional)
        public Guid? ResumeId { get; set; }

        [JsonIgnore]
        public virtual Resume? Resume { get; set; }

        // Foreign Key to JobSeeker
        [Required]
        [ForeignKey(nameof(JobSeeker))]
        public Guid JobSeekerId { get; set; }

        // Navigation Property
        public virtual JobSeeker JobSeeker { get; set; } = null!;

        // Profile details
        public string? ProfileName { get; set; }

        public string? ProfileSummary { get; set; }

        // Skills associated with this profile
        [JsonIgnore]

        public virtual ICollection<JobSeekerProfileSkill> JobSeekerProfileSkills
        {
            get; set;
        } = new List<JobSeekerProfileSkill>();

        // Educational qualifications
        [JsonIgnore]
        public virtual ICollection<Qualification> Qualifications
        { get; set; } = new List<Qualification>();

        // Previous work experience
        [JsonIgnore]
        public virtual ICollection<WorkExperience> WorkExperiences
        { get; set; } = new List<WorkExperience>();
    }
}
