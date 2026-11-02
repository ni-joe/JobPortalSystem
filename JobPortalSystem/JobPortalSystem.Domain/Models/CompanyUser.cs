using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace JobPortalSystem.Domain.Models
{
    public class CompanyUser
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? LastName { get; set; }

        [Required]
        public Enums.Role Role { get; set; }

        [MaxLength(100)]
        public string? UserName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(254)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone]
        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;

        // Company is optional
        public Guid? Company { get; set; }

        [ForeignKey(nameof(Company))]
        [JsonIgnore]
        public virtual JobProviderCompany? CompanyNavigation { get; set; }

        public virtual ICollection<JobPost> JobPosts { get; set; }
            = new List<JobPost>();
    }
}
