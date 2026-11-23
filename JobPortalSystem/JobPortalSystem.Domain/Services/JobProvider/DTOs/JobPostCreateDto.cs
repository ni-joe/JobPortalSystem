using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobPortalSystem.Domain.Services.JobProvider.DTOs
{
    public class JobPostCreateDto
    {
        [Required]
        public string JobTitle { get; set; } = string.Empty;

        [Required]
        public string JobSummary { get; set; } = string.Empty;

        [Required]
        public Guid CompanyId { get; set; }

        [Required]
        public Guid LocationId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [Required]
        public Guid IndustryId { get; set; }

        [Required]
        public Guid PostedBy { get; set; }
    }
}
