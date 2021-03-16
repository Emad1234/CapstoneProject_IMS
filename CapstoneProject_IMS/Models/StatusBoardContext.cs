using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CapstoneProject_IMS.Models
{
    public partial class StatusBoardContext : DbContext
    {
        public StatusBoardContext()
        {
        }

        public StatusBoardContext(DbContextOptions<StatusBoardContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Change> Change { get; set; }
        public virtual DbSet<ChangeAnnotation> ChangeAnnotation { get; set; }
        public virtual DbSet<Incident> Incident { get; set; }
        public virtual DbSet<IncidentAnnotation> IncidentAnnotation { get; set; }
        public virtual DbSet<IncidentManager> IncidentManager { get; set; }
        public virtual DbSet<IncidentSeverity> IncidentSeverity { get; set; }
        public virtual DbSet<IncidentTeam> IncidentTeam { get; set; }
        public virtual DbSet<Location> Location { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress19;Database=StatusBoardDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Change>(entity =>
            {
                entity.ToTable("change");

                entity.Property(e => e.ChangeId).HasColumnName("changeId");

                entity.Property(e => e.ChangeComplete).HasColumnName("changeComplete");

                entity.Property(e => e.ChangeDescription)
                    .IsRequired()
                    .HasColumnName("changeDescription")
                    .IsUnicode(false);

                entity.Property(e => e.ChangeEnd)
                    .HasColumnName("changeEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChangeStart)
                    .HasColumnName("changeStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChangeTitle)
                    .IsRequired()
                    .HasColumnName("changeTitle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalTicket)
                    .IsRequired()
                    .HasColumnName("externalTicket")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalTicketUrl)
                    .IsRequired()
                    .HasColumnName("externalTicketURL")
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("locationId");

                entity.Property(e => e.LocationUrl)
                    .IsRequired()
                    .HasColumnName("locationURL")
                    .IsUnicode(false);

                entity.Property(e => e.TeamId).HasColumnName("teamId");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Change)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_change_location");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Change)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_change_team");
            });

            modelBuilder.Entity<ChangeAnnotation>(entity =>
            {
                entity.HasKey(e => e.AnnotationId);

                entity.ToTable("changeAnnotation");

                entity.Property(e => e.AnnotationId).HasColumnName("annotationId");

                entity.Property(e => e.AnnotationContent)
                    .IsRequired()
                    .HasColumnName("annotationContent")
                    .IsUnicode(false);

                entity.Property(e => e.AnnotationVisible).HasColumnName("annotationVisible");

                entity.Property(e => e.ChangeId).HasColumnName("changeId");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Change)
                    .WithMany(p => p.ChangeAnnotation)
                    .HasForeignKey(d => d.ChangeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_changeAnnotation_change");
            });

            modelBuilder.Entity<Incident>(entity =>
            {
                entity.ToTable("incident");

                entity.Property(e => e.IncidentId).HasColumnName("incidentId");

                entity.Property(e => e.ExternalTicket)
                    .IsRequired()
                    .HasColumnName("externalTicket")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalTicketUrl)
                    .IsRequired()
                    .HasColumnName("externalTicketURL")
                    .IsUnicode(false);

                entity.Property(e => e.IncidentDescription)
                    .IsRequired()
                    .HasColumnName("incidentDescription")
                    .IsUnicode(false);

                entity.Property(e => e.IncidentEnd)
                    .HasColumnName("incidentEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.IncidentResolved).HasColumnName("incidentResolved");

                entity.Property(e => e.IncidentStart)
                    .HasColumnName("incidentStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.IncidentTitle)
                    .IsRequired()
                    .HasColumnName("incidentTitle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("locationId");

                entity.Property(e => e.LocationUrl)
                    .IsRequired()
                    .HasColumnName("locationURL")
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("managerId");

                entity.Property(e => e.SeverityId).HasColumnName("severityId");

                entity.Property(e => e.TeamId).HasColumnName("teamId");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Incident)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_incident_location");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Incident)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_incident_manager");

                entity.HasOne(d => d.Severity)
                    .WithMany(p => p.Incident)
                    .HasForeignKey(d => d.SeverityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_incident_severity");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Incident)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_incident_team");
            });

            modelBuilder.Entity<IncidentAnnotation>(entity =>
            {
                entity.HasKey(e => e.AnnotationId);

                entity.ToTable("incidentAnnotation");

                entity.Property(e => e.AnnotationId).HasColumnName("annotationId");

                entity.Property(e => e.AnnotationContent)
                    .IsRequired()
                    .HasColumnName("annotationContent")
                    .IsUnicode(false);

                entity.Property(e => e.AnnotationVisible).HasColumnName("annotationVisible");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IncidentId).HasColumnName("incidentId");

                entity.HasOne(d => d.Incident)
                    .WithMany(p => p.IncidentAnnotation)
                    .HasForeignKey(d => d.IncidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_incidentAnnotation_incident");
            });

            modelBuilder.Entity<IncidentManager>(entity =>
            {
                entity.HasKey(e => e.ManagerId);

                entity.ToTable("incidentManager");

                entity.Property(e => e.ManagerId).HasColumnName("managerId");

                entity.Property(e => e.ManagerEmail)
                    .IsRequired()
                    .HasColumnName("managerEmail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerHandle)
                    .IsRequired()
                    .HasColumnName("managerHandle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasColumnName("managerName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerPhone)
                    .IsRequired()
                    .HasColumnName("managerPhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IncidentSeverity>(entity =>
            {
                entity.HasKey(e => e.SeverityId);

                entity.ToTable("incidentSeverity");

                entity.Property(e => e.SeverityId).HasColumnName("severityId");

                entity.Property(e => e.SeverityDescription)
                    .IsRequired()
                    .HasColumnName("severityDescription")
                    .IsUnicode(false);

                entity.Property(e => e.SeverityName)
                    .IsRequired()
                    .HasColumnName("severityName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IncidentTeam>(entity =>
            {
                entity.HasKey(e => e.TeamId);

                entity.ToTable("incidentTeam");

                entity.Property(e => e.TeamId).HasColumnName("teamId");

                entity.Property(e => e.TeamEmail)
                    .IsRequired()
                    .HasColumnName("teamEmail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamFirstBackup)
                    .IsRequired()
                    .HasColumnName("teamFirstBackup")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamHandle)
                    .IsRequired()
                    .HasColumnName("teamHandle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamManager)
                    .IsRequired()
                    .HasColumnName("teamManager")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasColumnName("teamName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamPhone)
                    .IsRequired()
                    .HasColumnName("teamPhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamSecondBackup)
                    .IsRequired()
                    .HasColumnName("teamSecondBackup")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("location");

                entity.Property(e => e.LocationId).HasColumnName("locationId");

                entity.Property(e => e.LocationEmail)
                    .IsRequired()
                    .HasColumnName("locationEmail")
                    .IsUnicode(false);

                entity.Property(e => e.LocationFirstBackup)
                    .IsRequired()
                    .HasColumnName("locationFirstBackup")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationManager)
                    .IsRequired()
                    .HasColumnName("locationManager")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasColumnName("locationName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationPhone)
                    .IsRequired()
                    .HasColumnName("locationPhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationSecondBackup)
                    .IsRequired()
                    .HasColumnName("locationSecondBackup")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationUrl)
                    .IsRequired()
                    .HasColumnName("locationURL")
                    .IsUnicode(false);

                entity.Property(e => e.UsersCount).HasColumnName("usersCount");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
