using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalSystem.Domain.Services.JobProvider.DTOs
{
    public class JobPostResponseDto
    {
        public Guid Id { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public string JobSummary { get; set; } = string.Empty;
        public DateTime PostedDate { get; set; }

        public Guid CompanyId { get; set; }
        public Guid LocationId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid IndustryId { get; set; }
        public Guid PostedBy { get; set; }
    }
}
