﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PMS_API.Data;

#nullable disable

namespace PMSAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230112072416_Add AppUser")]
    partial class AddAppUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PMS_API.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<int>("BarangayId")
                        .HasColumnType("int");

                    b.Property<string>("HouseBlockLotNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PurokSitioId")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.HasIndex("BarangayId");

                    b.HasIndex("PurokSitioId");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.AppUser", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppUserId"));

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppUserId");

                    b.ToTable("AppUser", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.Barangay", b =>
                {
                    b.Property<int>("BarangayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BarangayId"));

                    b.Property<string>("BarangayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityMunicipalityId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("BarangayId");

                    b.HasIndex("CityMunicipalityId");

                    b.ToTable("Barangay", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.BloodType", b =>
                {
                    b.Property<int>("BloodTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BloodTypeId"));

                    b.Property<string>("BloodTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("BloodTypeId");

                    b.ToTable("BloodType", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.Citizenship", b =>
                {
                    b.Property<int>("CitizenshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CitizenshipId"));

                    b.Property<string>("CitizenshipName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("CitizenshipId");

                    b.ToTable("Citizenship", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.CityMunicipality", b =>
                {
                    b.Property<int>("CityMunicipalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityMunicipalityId"));

                    b.Property<string>("CityMunicipalityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("CityMunicipalityId");

                    b.ToTable("CityMunicipality", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.CivilStatus", b =>
                {
                    b.Property<int>("CivilStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CivilStatusId"));

                    b.Property<string>("CivilStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("CivilStatusId");

                    b.ToTable("CivilStatus", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"));

                    b.Property<string>("GenderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("GenderId");

                    b.ToTable("Gender", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.HealthBackground", b =>
                {
                    b.Property<int>("HealthBackgroundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HealthBackgroundId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMalnurish")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPwd")
                        .HasColumnType("bit");

                    b.Property<int>("PreExistingConditionId")
                        .HasColumnType("int");

                    b.Property<int>("VaccineTakenId")
                        .HasColumnType("int");

                    b.HasKey("HealthBackgroundId");

                    b.HasIndex("PreExistingConditionId");

                    b.HasIndex("VaccineTakenId");

                    b.ToTable("HealthBackground", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BloodTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CitizenshipId")
                        .HasColumnType("int");

                    b.Property<int>("CivilStatusId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<int>("HealthBackgroundId")
                        .HasColumnType("int");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRegisteredVoter")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrecintNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.Property<bool>("WithDriversLicense")
                        .HasColumnType("bit");

                    b.Property<bool>("WithNatId")
                        .HasColumnType("bit");

                    b.Property<bool>("WithSssGsis")
                        .HasColumnType("bit");

                    b.HasKey("PersonId");

                    b.HasIndex("AddressId");

                    b.HasIndex("BloodTypeId");

                    b.HasIndex("CitizenshipId");

                    b.HasIndex("CivilStatusId");

                    b.HasIndex("GenderId");

                    b.HasIndex("HealthBackgroundId");

                    b.ToTable("Person", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.PreExistingCondition", b =>
                {
                    b.Property<int>("PreExistingConditionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PreExistingConditionId"));

                    b.Property<string>("ConditionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("PreExistingConditionId");

                    b.ToTable("PreExistingCondition", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.PurokSitio", b =>
                {
                    b.Property<int>("PurokSitioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurokSitioId"));

                    b.Property<int>("BarangayId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PurokSitioName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PurokSitioId");

                    b.HasIndex("BarangayId");

                    b.ToTable("PurokSitio", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.Request", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestId"));

                    b.Property<DateTime>("DateRequested")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PickUpDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RequestTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestId");

                    b.HasIndex("PersonId");

                    b.HasIndex("RequestTypeId");

                    b.ToTable("Request", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.RequestType", b =>
                {
                    b.Property<int>("RequestTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestTypeId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("RequestTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestTypeId");

                    b.ToTable("RequestType", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.VaccineTaken", b =>
                {
                    b.Property<int>("VaccineTakenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VaccineTakenId"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("VaccineName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VaccineTakenId");

                    b.ToTable("VaccineTaken", (string)null);
                });

            modelBuilder.Entity("PMS_API.Models.Address", b =>
                {
                    b.HasOne("PMS_API.Models.Barangay", "Barangay")
                        .WithMany()
                        .HasForeignKey("BarangayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.Models.PurokSitio", "PurokSitio")
                        .WithMany()
                        .HasForeignKey("PurokSitioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barangay");

                    b.Navigation("PurokSitio");
                });

            modelBuilder.Entity("PMS_API.Models.Barangay", b =>
                {
                    b.HasOne("PMS_API.Models.CityMunicipality", "CityMunicipality")
                        .WithMany()
                        .HasForeignKey("CityMunicipalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CityMunicipality");
                });

            modelBuilder.Entity("PMS_API.Models.HealthBackground", b =>
                {
                    b.HasOne("PMS_API.Models.PreExistingCondition", "PreExistingCondition")
                        .WithMany()
                        .HasForeignKey("PreExistingConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.Models.VaccineTaken", "VaccineTaken")
                        .WithMany()
                        .HasForeignKey("VaccineTakenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PreExistingCondition");

                    b.Navigation("VaccineTaken");
                });

            modelBuilder.Entity("PMS_API.Models.Person", b =>
                {
                    b.HasOne("PMS_API.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.Models.BloodType", "BloodType")
                        .WithMany()
                        .HasForeignKey("BloodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.Models.Citizenship", "Citizenship")
                        .WithMany()
                        .HasForeignKey("CitizenshipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.Models.CivilStatus", "CivilStatus")
                        .WithMany()
                        .HasForeignKey("CivilStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.Models.HealthBackground", "HealthBackground")
                        .WithMany()
                        .HasForeignKey("HealthBackgroundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("BloodType");

                    b.Navigation("Citizenship");

                    b.Navigation("CivilStatus");

                    b.Navigation("Gender");

                    b.Navigation("HealthBackground");
                });

            modelBuilder.Entity("PMS_API.Models.PurokSitio", b =>
                {
                    b.HasOne("PMS_API.Models.Barangay", "Barangay")
                        .WithMany()
                        .HasForeignKey("BarangayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barangay");
                });

            modelBuilder.Entity("PMS_API.Models.Request", b =>
                {
                    b.HasOne("PMS_API.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.Models.RequestType", "RequestType")
                        .WithMany()
                        .HasForeignKey("RequestTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("RequestType");
                });
#pragma warning restore 612, 618
        }
    }
}
