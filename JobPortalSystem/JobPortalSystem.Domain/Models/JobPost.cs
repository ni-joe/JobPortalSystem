using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
    public class JobPost
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(150)]
        public string JobTitle { get; set; } = string.Empty;

        [Required]
        [MaxLength(3000)]
        public string JobSummary { get; set; } = string.Empty;

        [Required]
        public Guid LocationId { get; set; }

        [ForeignKey(nameof(LocationId))]
        public virtual Location Location { get; set; } = null!;

        [Required]
        public Guid CompanyId { get; set; }

        [ForeignKey(nameof(CompanyId))]
        public virtual JobProviderCompany Company { get; set; } = null!;

        [Required]
        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual JobCategory JobCategory { get; set; } = null!;

        [Required]
        public Guid IndustryId { get; set; }

        [ForeignKey(nameof(IndustryId))]
        public virtual Industry Industry { get; set; } = null!;

        [Required]
        public Guid PostedBy { get; set; }

        [ForeignKey(nameof(PostedBy))]
        public virtual CompanyUser PostedByNavigation { get; set; } = null!;

        [Required]
        public DateTime PostedDate { get; set; } = DateTime.UtcNow;

        public virtual ICollection<JobResponsibility> JobResponsibilities
        { get; set; } = new List<JobResponsibility>();

        public virtual ICollection<JobApplication> JobApplications
        { get; set; } = new List<JobApplication>();

        public virtual ICollection<SavedJob> SavedJobs
        { get; set; } = new List<SavedJob>();

        public virtual ICollection<Interview> Interviews
        { get; set; } = new List<Interview>();
    }
}
