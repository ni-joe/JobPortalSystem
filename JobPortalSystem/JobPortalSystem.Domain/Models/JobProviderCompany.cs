using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
  public class JobProviderCompany
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(150)]
        public string LegalName { get; set; } = string.Empty;

        [MaxLength(2000)]
        public string? Summary { get; set; }

        [Required]
        public Guid IndustryId { get; set; }

        [ForeignKey(nameof(IndustryId))]
        public virtual Industry Industry { get; set; } = null!;

        [Required]
        [EmailAddress]
        [MaxLength(254)]
        public string Email { get; set; } = string.Empty;

        [Phone]
        public string? Phone { get; set; }

        [MaxLength(300)]
        public string Address { get; set; } = string.Empty;

        [Url]
        [MaxLength(2048)]
        public string? Website { get; set; }

        [Required]
        public Guid LocationId { get; set; }

        [ForeignKey(nameof(LocationId))]
        public virtual Location LocationNavigation { get; set; } = null!;

        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
            = new List<CompanyUser>();

        public virtual ICollection<JobPost> JobPosts { get; set; }
            = new List<JobPost>();
    }
}
