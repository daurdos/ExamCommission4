﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Phd.Models;

namespace Phd.Migrations
{
    [DbContext(typeof(PhdContext))]
    partial class PhdContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Phd.Models.AcademicDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacultyId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("AcademicDepartment");
                });

            modelBuilder.Entity("Phd.Models.BDirection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademicDepartmentId");

                    b.Property<string>("Cypher");

                    b.Property<string>("NameEng");

                    b.Property<string>("NameKaz");

                    b.Property<string>("NameRus");

                    b.HasKey("Id");

                    b.HasIndex("AcademicDepartmentId");

                    b.ToTable("BDirection");
                });

            modelBuilder.Entity("Phd.Models.BMajor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademicDepartmentId");

                    b.Property<string>("Cypher");

                    b.Property<string>("NameEng");

                    b.Property<string>("NameKaz");

                    b.Property<string>("NameRus");

                    b.HasKey("Id");

                    b.HasIndex("AcademicDepartmentId");

                    b.ToTable("BMajor");
                });

            modelBuilder.Entity("Phd.Models.BRStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AbsentMemberFullName");

                    b.Property<string>("AnswerCharacteristic");

                    b.Property<int>("BRStudentGroupId");

                    b.Property<string>("ConsultantAcademicDegree");

                    b.Property<string>("ConsultantFname");

                    b.Property<string>("ConsultantLname");

                    b.Property<string>("ConsultantMname");

                    b.Property<string>("ConsultantPosition");

                    b.Property<string>("ConsultantWorkPlace");

                    b.Property<int>("CreditNumber");

                    b.Property<DateTime>("DefenceDate");

                    b.Property<int>("DrawingsTablesNumber");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Fname");

                    b.Property<string>("Iin");

                    b.Property<string>("LevelOfPreparation");

                    b.Property<string>("Lname");

                    b.Property<string>("Mname");

                    b.Property<string>("ProtocolNumber");

                    b.Property<string>("ReviewerAcademicDegree");

                    b.Property<string>("ReviewerFname");

                    b.Property<int>("ReviewerGrade");

                    b.Property<string>("ReviewerLname");

                    b.Property<string>("ReviewerMname");

                    b.Property<string>("ReviewerPosition");

                    b.Property<string>("ReviewerReviewAvailability");

                    b.Property<string>("ReviewerWorkPlace");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("StudyYear");

                    b.Property<string>("SupervisorAcademicDegree");

                    b.Property<string>("SupervisorConclusion");

                    b.Property<string>("SupervisorFname");

                    b.Property<string>("SupervisorLname");

                    b.Property<string>("SupervisorMname");

                    b.Property<string>("SupervisorPosition");

                    b.Property<string>("SupervisorReviewAvailability");

                    b.Property<string>("SupervisorWorkPlace");

                    b.Property<int>("ThesisPagesNumber");

                    b.Property<string>("ThesisTopicEng");

                    b.Property<string>("ThesisTopicKaz");

                    b.Property<string>("ThesisTopicRus");

                    b.Property<string>("TypeOfStateAttestation");

                    b.HasKey("Id");

                    b.HasIndex("BRStudentGroupId");

                    b.ToTable("BRStudent");
                });

            modelBuilder.Entity("Phd.Models.BRStudentDoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BRStudentId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("StudentDocTypeId");

                    b.HasKey("Id");

                    b.HasIndex("BRStudentId");

                    b.HasIndex("StudentDocTypeId");

                    b.ToTable("BRStudentDoc");
                });

            modelBuilder.Entity("Phd.Models.BRStudentGrade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BRStudentId");

                    b.Property<string>("Opinion");

                    b.Property<string>("Question");

                    b.Property<string>("UserId");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("BRStudentId");

                    b.HasIndex("UserId");

                    b.ToTable("BRStudentGrade");
                });

            modelBuilder.Entity("Phd.Models.BRStudentGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BMajorId");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("BMajorId");

                    b.ToTable("BRStudentGroup");
                });

            modelBuilder.Entity("Phd.Models.DictionaryAcademicDegree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ValueEng");

                    b.Property<string>("ValueKaz");

                    b.Property<string>("ValueRus");

                    b.HasKey("Id");

                    b.ToTable("DictionaryAcademicDegree");
                });

            modelBuilder.Entity("Phd.Models.DictionaryStatusAvailability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ValueEng");

                    b.Property<string>("ValueKaz");

                    b.Property<string>("ValueRus");

                    b.HasKey("Id");

                    b.ToTable("DictionaryStatusAvailability");
                });

            modelBuilder.Entity("Phd.Models.DictionaryStatusConclusion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ValueEng");

                    b.Property<string>("ValueKaz");

                    b.Property<string>("ValueRus");

                    b.HasKey("Id");

                    b.ToTable("DictionaryStatusConclusion");
                });

            modelBuilder.Entity("Phd.Models.DictionaryStudyYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("DictionaryStudyYear");
                });

            modelBuilder.Entity("Phd.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("Phd.Models.StudentDocType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("StudentDocType");
                });

            modelBuilder.Entity("Phd.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("BMajorId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MiddleName");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UName");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("BMajorId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Phd.Models.UserActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activity");

                    b.Property<string>("Description");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("UserActivitiy");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Phd.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Phd.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Phd.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Phd.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Phd.Models.AcademicDepartment", b =>
                {
                    b.HasOne("Phd.Models.Faculty", "Faculty")
                        .WithMany("AcademicDepartment")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Phd.Models.BDirection", b =>
                {
                    b.HasOne("Phd.Models.AcademicDepartment", "AcademicDepartment")
                        .WithMany("BDirection")
                        .HasForeignKey("AcademicDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Phd.Models.BMajor", b =>
                {
                    b.HasOne("Phd.Models.AcademicDepartment", "AcademicDepartment")
                        .WithMany("BMajor")
                        .HasForeignKey("AcademicDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Phd.Models.BRStudent", b =>
                {
                    b.HasOne("Phd.Models.BRStudentGroup")
                        .WithMany("BRStudent")
                        .HasForeignKey("BRStudentGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Phd.Models.BRStudentDoc", b =>
                {
                    b.HasOne("Phd.Models.BRStudent", "BRStudent")
                        .WithMany("BRStudentDoc")
                        .HasForeignKey("BRStudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Phd.Models.StudentDocType", "StudentDocType")
                        .WithMany("BRStudentDoc")
                        .HasForeignKey("StudentDocTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Phd.Models.BRStudentGrade", b =>
                {
                    b.HasOne("Phd.Models.BRStudent", "BRStudent")
                        .WithMany("BRStudentGrade")
                        .HasForeignKey("BRStudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Phd.Models.User", "User")
                        .WithMany("BRStudentGrades")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Phd.Models.BRStudentGroup", b =>
                {
                    b.HasOne("Phd.Models.BMajor", "BMajor")
                        .WithMany()
                        .HasForeignKey("BMajorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Phd.Models.User", b =>
                {
                    b.HasOne("Phd.Models.BMajor", "BMajor")
                        .WithMany()
                        .HasForeignKey("BMajorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
