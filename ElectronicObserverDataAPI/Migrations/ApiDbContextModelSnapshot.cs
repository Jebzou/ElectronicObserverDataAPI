﻿// <auto-generated />
using System;
using ElectronicObserverDataAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectronicObserverDataAPI.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1");

            modelBuilder.Entity("ElectronicObserverDataAPI.Models.EquipmentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "equipmentId");

                    b.Property<int?>("FitBonusIssueModelId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "level");

                    b.HasKey("Id");

                    b.HasIndex("FitBonusIssueModelId");

                    b.ToTable("EquipmentModel");

                    b.HasAnnotation("Relational:JsonPropertyName", "equipments");
                });

            modelBuilder.Entity("ElectronicObserverDataAPI.Models.EquipmentUpgradeIssueModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("ActualUpgrades")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "actual");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("DataVersion")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "data_version");

                    b.Property<int>("Day")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "day");

                    b.Property<string>("ExpectedUpgrades")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "expected");

                    b.Property<int>("HelperId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "helperId");

                    b.Property<int>("IssueState")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "state");

                    b.Property<string>("SoftwareVersion")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "software_version");

                    b.HasKey("Id");

                    b.ToTable("EquipmentUpgradeIssues");
                });

            modelBuilder.Entity("ElectronicObserverDataAPI.Models.FitBonusIssueModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<int>("ActualBonusId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("DataVersion")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "data_version");

                    b.Property<int>("ExpectedBonusId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IssueState")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "state");

                    b.Property<int>("ShipId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SoftwareVersion")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "software_version");

                    b.HasKey("Id");

                    b.HasIndex("ActualBonusId");

                    b.HasIndex("ExpectedBonusId");

                    b.HasIndex("ShipId");

                    b.ToTable("FitBonusIssues");
                });

            modelBuilder.Entity("ElectronicObserverDataAPI.Models.FitBonusValueModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<int>("ASW")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "tais");

                    b.Property<int>("Accuracy")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "houm");

                    b.Property<int>("AntiAir")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "tyku");

                    b.Property<int>("Armor")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "souk");

                    b.Property<int>("Evasion")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "kaih");

                    b.Property<int>("Firepower")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "houg");

                    b.Property<int>("LOS")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "saku");

                    b.Property<int>("Range")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "leng");

                    b.Property<int>("Torpedo")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "raig");

                    b.HasKey("Id");

                    b.ToTable("FitBonusValueModel");

                    b.HasAnnotation("Relational:JsonPropertyName", "expected");
                });

            modelBuilder.Entity("ElectronicObserverDataAPI.Models.QuestTranslationMissingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("ApiId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "api_id");

                    b.Property<int>("DataVersion")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "data_version");

                    b.Property<string>("Desription")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "description");

                    b.Property<int>("IssueState")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "state");

                    b.Property<string>("SoftwareVersion")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "software_version");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "title");

                    b.HasKey("Id");

                    b.ToTable("QuestTranslationMissing");
                });

            modelBuilder.Entity("ElectronicObserverDataAPI.Models.ShipModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<int>("ASW")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "asw");

                    b.Property<int>("Accuracy")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "accuracy");

                    b.Property<int>("AntiAir")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "antiAir");

                    b.Property<int>("Armor")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "armor");

                    b.Property<int>("Evasion")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "evasion");

                    b.Property<int>("Firepower")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "firepower");

                    b.Property<int>("LOS")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "los");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "level");

                    b.Property<int>("Range")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "range");

                    b.Property<int>("ShipId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "shipId");

                    b.Property<int>("Torpedo")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "torpedo");

                    b.HasKey("Id");

                    b.ToTable("ShipModel");

                    b.HasAnnotation("Relational:JsonPropertyName", "ship");
                });

            modelBuilder.Entity("ElectronicObserverDataAPI.Models.EquipmentModel", b =>
                {
                    b.HasOne("ElectronicObserverDataAPI.Models.FitBonusIssueModel", null)
                        .WithMany("Equipments")
                        .HasForeignKey("FitBonusIssueModelId");
                });

            modelBuilder.Entity("ElectronicObserverDataAPI.Models.FitBonusIssueModel", b =>
                {
                    b.HasOne("ElectronicObserverDataAPI.Models.FitBonusValueModel", "ActualBonus")
                        .WithMany()
                        .HasForeignKey("ActualBonusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElectronicObserverDataAPI.Models.FitBonusValueModel", "ExpectedBonus")
                        .WithMany()
                        .HasForeignKey("ExpectedBonusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElectronicObserverDataAPI.Models.ShipModel", "Ship")
                        .WithMany()
                        .HasForeignKey("ShipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActualBonus");

                    b.Navigation("ExpectedBonus");

                    b.Navigation("Ship");
                });

            modelBuilder.Entity("ElectronicObserverDataAPI.Models.FitBonusIssueModel", b =>
                {
                    b.Navigation("Equipments");
                });
#pragma warning restore 612, 618
        }
    }
}
