// <auto-generated />
using System;
using Jobee_API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jobee_API.Migrations
{
    [DbContext(typeof(Project_JobeeContext))]
    [Migration("20230223150156_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Jobee_API.Entities.Activity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Idcv")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("IDCV");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("Idcv");

                    b.ToTable("Activity", (string)null);
                });

            modelBuilder.Entity("Jobee_API.Entities.Award", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Idcv")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("IDCV");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("Idcv");

                    b.ToTable("Award", (string)null);
                });

            modelBuilder.Entity("Jobee_API.Entities.Certificate", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("ID");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Idcv")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("IDCV");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Idcv");

                    b.ToTable("Certificate", (string)null);
                });

            modelBuilder.Entity("Jobee_API.Entities.Education", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<double>("Gpa")
                        .HasColumnType("float")
                        .HasColumnName("GPA");

                    b.Property<string>("Idcv")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("IDCV");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("Idcv");

                    b.ToTable("Education", (string)null);
                });

            modelBuilder.Entity("Jobee_API.Entities.Project", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Idcv")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("IDCV");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("TeamSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technology")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Idcv");

                    b.ToTable("Project", (string)null);
                });

            modelBuilder.Entity("Jobee_API.Entities.TbAccount", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("ID");

                    b.Property<string>("IdtypeAccount")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("IDTypeAccount");

                    b.Property<string>("Passwork")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdtypeAccount");

                    b.ToTable("tbAccount", (string)null);
                });

            modelBuilder.Entity("Jobee_API.Entities.TbAdmin", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("ID");

                    b.Property<string>("Idprofile")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("IDProfile");

                    b.HasKey("Id");

                    b.HasIndex("Idprofile");

                    b.ToTable("tbAdmin", (string)null);
                });

            modelBuilder.Entity("Jobee_API.Entities.TbCv", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("ID");

                    b.Property<string>("ApplyPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarrerObjiect")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentJob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesiredWorkLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DesirySalary")
                        .HasColumnType("money");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idemployee")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("IDEmployee");

                    b.Property<string>("SoftSkill")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkExperience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingForm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Idemployee");

                    b.ToTable("tbCV", (string)null);
                });

            modelBuilder.Entity("Jobee_API.Entities.TbEmployee", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("ID");

                    b.Property<string>("Idprofile")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("IDProfile");

                    b.HasKey("Id");

                    b.HasIndex("Idprofile");

                    b.ToTable("tbEmployee", (string)null);
                });

            modelBuilder.Entity("Jobee_API.Entities.TbProfile", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("ID");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DetailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Idaccount")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("IDAccount");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialNetwork")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Idaccount");

                    b.ToTable("tbProfile", (string)null);
                });

            modelBuilder.Entity("Jobee_API.Entities.TbTypeAccount", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbTypeAccount", (string)null);
                });

            modelBuilder.Entity("Jobee_API.Entities.Activity", b =>
                {
                    b.HasOne("Jobee_API.Entities.TbCv", "IdcvNavigation")
                        .WithMany("Activities")
                        .HasForeignKey("Idcv")
                        .IsRequired()
                        .HasConstraintName("FK_Activity_tbCV");

                    b.Navigation("IdcvNavigation");
                });

            modelBuilder.Entity("Jobee_API.Entities.Award", b =>
                {
                    b.HasOne("Jobee_API.Entities.TbCv", "IdcvNavigation")
                        .WithMany("Awards")
                        .HasForeignKey("Idcv")
                        .IsRequired()
                        .HasConstraintName("FK_Award_tbCV");

                    b.Navigation("IdcvNavigation");
                });

            modelBuilder.Entity("Jobee_API.Entities.Certificate", b =>
                {
                    b.HasOne("Jobee_API.Entities.TbCv", "IdcvNavigation")
                        .WithMany("Certificates")
                        .HasForeignKey("Idcv")
                        .IsRequired()
                        .HasConstraintName("FK_Certificate_tbCV");

                    b.Navigation("IdcvNavigation");
                });

            modelBuilder.Entity("Jobee_API.Entities.Education", b =>
                {
                    b.HasOne("Jobee_API.Entities.TbCv", "IdcvNavigation")
                        .WithMany("Educations")
                        .HasForeignKey("Idcv")
                        .IsRequired()
                        .HasConstraintName("FK_Education_tbCV");

                    b.Navigation("IdcvNavigation");
                });

            modelBuilder.Entity("Jobee_API.Entities.Project", b =>
                {
                    b.HasOne("Jobee_API.Entities.TbCv", "IdcvNavigation")
                        .WithMany("Projects")
                        .HasForeignKey("Idcv")
                        .IsRequired()
                        .HasConstraintName("FK_Project_tbCV");

                    b.Navigation("IdcvNavigation");
                });

            modelBuilder.Entity("Jobee_API.Entities.TbAccount", b =>
                {
                    b.HasOne("Jobee_API.Entities.TbTypeAccount", "IdtypeAccountNavigation")
                        .WithMany("TbAccounts")
                        .HasForeignKey("IdtypeAccount")
                        .IsRequired()
                        .HasConstraintName("FK_tbAccount_tbTypeAccount");

                    b.Navigation("IdtypeAccountNavigation");
                });

            modelBuilder.Entity("Jobee_API.Entities.TbAdmin", b =>
                {
                    b.HasOne("Jobee_API.Entities.TbProfile", "IdprofileNavigation")
                        .WithMany("TbAdmins")
                        .HasForeignKey("Idprofile")
                        .IsRequired()
                        .HasConstraintName("FK_tbAdmin_tbProfile");

                    b.Navigation("IdprofileNavigation");
                });

            modelBuilder.Entity("Jobee_API.Entities.TbCv", b =>
                {
                    b.HasOne("Jobee_API.Entities.TbEmployee", "IdemployeeNavigation")
                        .WithMany("TbCvs")
                        .HasForeignKey("Idemployee")
                        .IsRequired()
                        .HasConstraintName("FK_tbCV_tbEmployee");

                    b.Navigation("IdemployeeNavigation");
                });

            modelBuilder.Entity("Jobee_API.Entities.TbEmployee", b =>
                {
                    b.HasOne("Jobee_API.Entities.TbProfile", "IdprofileNavigation")
                        .WithMany("TbEmployees")
                        .HasForeignKey("Idprofile")
                        .IsRequired()
                        .HasConstraintName("FK_tbEmployee_tbProfile");

                    b.Navigation("IdprofileNavigation");
                });

            modelBuilder.Entity("Jobee_API.Entities.TbProfile", b =>
                {
                    b.HasOne("Jobee_API.Entities.TbAccount", "IdaccountNavigation")
                        .WithMany("TbProfiles")
                        .HasForeignKey("Idaccount")
                        .IsRequired()
                        .HasConstraintName("FK_tbProfile_tbAccount");

                    b.Navigation("IdaccountNavigation");
                });

            modelBuilder.Entity("Jobee_API.Entities.TbAccount", b =>
                {
                    b.Navigation("TbProfiles");
                });

            modelBuilder.Entity("Jobee_API.Entities.TbCv", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Awards");

                    b.Navigation("Certificates");

                    b.Navigation("Educations");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Jobee_API.Entities.TbEmployee", b =>
                {
                    b.Navigation("TbCvs");
                });

            modelBuilder.Entity("Jobee_API.Entities.TbProfile", b =>
                {
                    b.Navigation("TbAdmins");

                    b.Navigation("TbEmployees");
                });

            modelBuilder.Entity("Jobee_API.Entities.TbTypeAccount", b =>
                {
                    b.Navigation("TbAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
