using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
    public class JobPortalSystemWebApiContext : DbContext
    {
        public JobPortalSystemWebApiContext() { }

        public JobPortalSystemWebApiContext(DbContextOptions<JobPortalSystemWebApiContext> options)
            : base(options)
        {
        }
        // Authentication and Registration
        public DbSet<AuthUser> AuthUsers { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<SignUpRequest> SignUpRequests { get; set; }

        // Job Seeker
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<JobSeekerProfile> JobSeekerProfiles { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<JobSeekerProfileSkill> JobSeekerProfileSkills { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }

        // Company and Job Provider
        public DbSet<JobProviderCompany> JobProviderCompanies { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }

        // Job Management
        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<JobResponsibility> JobResponsibilities { get; set; }

        // Job Applications and Interviews
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<SavedJob> SavedJobs { get; set; }
        public DbSet<Interview> Interviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Prevent duplicate CompanyUser emails
            modelBuilder.Entity<CompanyUser>()
                .HasIndex(x => x.Email)
                .IsUnique();

            // Prevent duplicate applications for the same job
            // by the same job seeker
            modelBuilder.Entity<JobApplication>()
                .HasIndex(x => new { x.JobPostId, x.Applicant })
                .IsUnique();

            // Prevent saving the same job more than once
            // by the same job seeker
            modelBuilder.Entity<SavedJob>()
                .HasIndex(x => new { x.Job, x.SavedBy })
                .IsUnique();

            // Prevent duplicate skills in the same profile
            modelBuilder.Entity<JobSeekerProfileSkill>()
                .HasIndex(x => new
                {
                    x.JobSeekerProfileId,
                    x.SkillId
                })
                .IsUnique();

            // CompanyUser -> Company relationship
            modelBuilder.Entity<CompanyUser>()
                .HasOne(x => x.CompanyNavigation)
                .WithMany(x => x.CompanyUsers)
                .HasForeignKey(x => x.Company)
                .IsRequired(false);

            // Prevent duplicate SystemUser emails
            modelBuilder.Entity<SystemUser>()
                .HasIndex(x => x.Email)
                .IsUnique();

            // Ensure one AuthUser per SystemUser
            modelBuilder.Entity<AuthUser>()
                .HasIndex(x => x.SystemUserId)
                .IsUnique();

            // Configure one-to-one SystemUser and AuthUser relationship
            modelBuilder.Entity<AuthUser>()
                .HasOne(x => x.SystemUser)
                .WithOne(x => x.AuthUser)
                .HasForeignKey<AuthUser>(x => x.SystemUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
