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
        public int Job_ID { get; set; }

        [ForeignKey("JobProvider")]
        public int JobProvider_ID { get; set; }
        public virtual JobProvider JobProvider { get; set; }

        [ForeignKey("Company")]
        public int Company_ID { get; set; }
        public virtual Company Company { get; set; }

        public int Category_ID { get; set; }
        public int Location_ID { get; set; }

        [Required]
        [MaxLength(150)]
        public string Job_Name { get; set; }

        [MaxLength(50)]
        public string Job_Type { get; set; }

        public string Job_Requirement { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Minimum_Salary { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Maximum_Salary { get; set; }

        public DateTime Job_Post_Expiry_Date { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }
    }
}
