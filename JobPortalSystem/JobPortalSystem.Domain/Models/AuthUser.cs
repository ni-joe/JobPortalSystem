using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
    public class AuthUser
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        // Foreign key to SystemUser
        [Required]
        public Guid SystemUserId { get; set; }

        // Navigation property
        public SystemUser? SystemUser { get; set; }

        [Required]
        public string UserName { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
        public string? ConnectionId { get; set; }
        public bool? OnlineStatus { get; set; } = false;
    }
}
