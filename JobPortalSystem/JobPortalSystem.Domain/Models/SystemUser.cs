using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
    public class SystemUser
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        public Enums.Role? Role { get; set; }
        public bool IsEmailVerified { get; set; } = false;

        // Store only the hash of the verification token
        public string? VerificationTokenHash { get; set; }

        public DateTime? TokenExpiry { get; set; }

        public virtual AuthUser? AuthUser { get; set; }
    }
}
