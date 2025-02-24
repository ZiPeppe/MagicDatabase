﻿// <auto-generated />
using MagicCardsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicDatabase.Migrations
{
    [DbContext(typeof(MagicCardsContext))]
    [Migration("20250113161509_EditCard")]
    partial class EditCard
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicDatabase.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardId"));

                    b.Property<int>("CardArtTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CardLanguageId")
                        .HasColumnType("int");

                    b.Property<string>("CardName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("CardRarityId")
                        .HasColumnType("int");

                    b.Property<int>("CardStatusId")
                        .HasColumnType("int");

                    b.Property<int>("CardSubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("CardId");

                    b.HasIndex("CardArtTypeId");

                    b.HasIndex("CardLanguageId");

                    b.HasIndex("CardRarityId");

                    b.HasIndex("CardStatusId");

                    b.HasIndex("CardSubCategoryId");

                    b.ToTable("Cards", (string)null);
                });

            modelBuilder.Entity("MagicDatabase.CardArtType", b =>
                {
                    b.Property<int>("CardArtTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardArtTypeId"));

                    b.Property<string>("CardArtTypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CardArtTypeId");

                    b.ToTable("CardArtTypes", (string)null);

                    b.HasData(
                        new
                        {
                            CardArtTypeId = 1,
                            CardArtTypeName = "Foil"
                        },
                        new
                        {
                            CardArtTypeId = 2,
                            CardArtTypeName = "Foil Etched"
                        },
                        new
                        {
                            CardArtTypeId = 3,
                            CardArtTypeName = "Reverse Foil"
                        },
                        new
                        {
                            CardArtTypeId = 4,
                            CardArtTypeName = "Full Art"
                        },
                        new
                        {
                            CardArtTypeId = 5,
                            CardArtTypeName = "Full Art Foil"
                        },
                        new
                        {
                            CardArtTypeId = 6,
                            CardArtTypeName = "Full Art Other Foilage"
                        },
                        new
                        {
                            CardArtTypeId = 7,
                            CardArtTypeName = "Double Art"
                        },
                        new
                        {
                            CardArtTypeId = 8,
                            CardArtTypeName = "Double Art Foil"
                        },
                        new
                        {
                            CardArtTypeId = 9,
                            CardArtTypeName = "Borderless"
                        },
                        new
                        {
                            CardArtTypeId = 10,
                            CardArtTypeName = "Borderless Foil"
                        },
                        new
                        {
                            CardArtTypeId = 11,
                            CardArtTypeName = "Alternative Art"
                        },
                        new
                        {
                            CardArtTypeId = 12,
                            CardArtTypeName = "Alternative Art Foil"
                        },
                        new
                        {
                            CardArtTypeId = 13,
                            CardArtTypeName = "Promo"
                        },
                        new
                        {
                            CardArtTypeId = 14,
                            CardArtTypeName = "Promo Foil"
                        },
                        new
                        {
                            CardArtTypeId = 15,
                            CardArtTypeName = "Missprint"
                        });
                });

            modelBuilder.Entity("MagicDatabase.CardCategory", b =>
                {
                    b.Property<int>("CardCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardCategoryId"));

                    b.Property<string>("CardCategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CardCategoryId");

                    b.ToTable("CardCategories", (string)null);

                    b.HasData(
                        new
                        {
                            CardCategoryId = 1,
                            CardCategoryName = "Creatura"
                        },
                        new
                        {
                            CardCategoryId = 2,
                            CardCategoryName = "Incantesimo"
                        },
                        new
                        {
                            CardCategoryId = 3,
                            CardCategoryName = "Artefatto"
                        });
                });

            modelBuilder.Entity("MagicDatabase.CardLanguage", b =>
                {
                    b.Property<int>("CardLanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardLanguageId"));

                    b.Property<string>("CardLanguageName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CardLanguageId");

                    b.ToTable("CardLanguages", (string)null);

                    b.HasData(
                        new
                        {
                            CardLanguageId = 1,
                            CardLanguageName = "Italian"
                        },
                        new
                        {
                            CardLanguageId = 2,
                            CardLanguageName = "English"
                        },
                        new
                        {
                            CardLanguageId = 3,
                            CardLanguageName = "Japanese"
                        },
                        new
                        {
                            CardLanguageId = 4,
                            CardLanguageName = "French"
                        },
                        new
                        {
                            CardLanguageId = 5,
                            CardLanguageName = "German"
                        },
                        new
                        {
                            CardLanguageId = 6,
                            CardLanguageName = "Russian"
                        },
                        new
                        {
                            CardLanguageId = 7,
                            CardLanguageName = "Spanish"
                        },
                        new
                        {
                            CardLanguageId = 8,
                            CardLanguageName = "Portuguese"
                        },
                        new
                        {
                            CardLanguageId = 9,
                            CardLanguageName = "Chinese"
                        },
                        new
                        {
                            CardLanguageId = 10,
                            CardLanguageName = "Korean"
                        });
                });

            modelBuilder.Entity("MagicDatabase.CardRarity", b =>
                {
                    b.Property<int>("CardRarityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardRarityId"));

                    b.Property<string>("CardRarityName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CardRarityId");

                    b.ToTable("CardRarities", (string)null);

                    b.HasData(
                        new
                        {
                            CardRarityId = 1,
                            CardRarityName = "Common"
                        },
                        new
                        {
                            CardRarityId = 2,
                            CardRarityName = "Uncommon"
                        },
                        new
                        {
                            CardRarityId = 3,
                            CardRarityName = "Rare"
                        },
                        new
                        {
                            CardRarityId = 4,
                            CardRarityName = "Mythic Rare"
                        });
                });

            modelBuilder.Entity("MagicDatabase.CardStatus", b =>
                {
                    b.Property<int>("CardStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardStatusId"));

                    b.Property<string>("CardStatusName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CardStatusId");

                    b.ToTable("CardStatuses", (string)null);

                    b.HasData(
                        new
                        {
                            CardStatusId = 1,
                            CardStatusName = "Trashed"
                        },
                        new
                        {
                            CardStatusId = 2,
                            CardStatusName = "Damaged"
                        },
                        new
                        {
                            CardStatusId = 3,
                            CardStatusName = "Poor"
                        },
                        new
                        {
                            CardStatusId = 4,
                            CardStatusName = "Heavily Played"
                        },
                        new
                        {
                            CardStatusId = 5,
                            CardStatusName = "Lightly Played"
                        },
                        new
                        {
                            CardStatusId = 6,
                            CardStatusName = "Good"
                        },
                        new
                        {
                            CardStatusId = 7,
                            CardStatusName = "Excellent"
                        },
                        new
                        {
                            CardStatusId = 8,
                            CardStatusName = "Near Mint"
                        },
                        new
                        {
                            CardStatusId = 9,
                            CardStatusName = "Mint"
                        },
                        new
                        {
                            CardStatusId = 10,
                            CardStatusName = "Sealed"
                        });
                });

            modelBuilder.Entity("MagicDatabase.CardSubCategory", b =>
                {
                    b.Property<int>("CardSubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardSubCategoryId"));

                    b.Property<int>("CardCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CardSubCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardSubCategoryId");

                    b.HasIndex("CardCategoryID");

                    b.ToTable("CardSubCategories", (string)null);

                    b.HasData(
                        new
                        {
                            CardSubCategoryId = 1,
                            CardCategoryID = 1,
                            CardSubCategoryName = "Elfo"
                        },
                        new
                        {
                            CardSubCategoryId = 2,
                            CardCategoryID = 1,
                            CardSubCategoryName = "Zombie"
                        },
                        new
                        {
                            CardSubCategoryId = 3,
                            CardCategoryID = 2,
                            CardSubCategoryName = "Aura"
                        },
                        new
                        {
                            CardSubCategoryId = 4,
                            CardCategoryID = 3,
                            CardSubCategoryName = "Equipaggiamento"
                        });
                });

            modelBuilder.Entity("MagicDatabase.Card", b =>
                {
                    b.HasOne("MagicDatabase.CardArtType", "CardArtType")
                        .WithMany()
                        .HasForeignKey("CardArtTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MagicDatabase.CardLanguage", "CardLanguage")
                        .WithMany()
                        .HasForeignKey("CardLanguageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MagicDatabase.CardRarity", "CardRarity")
                        .WithMany()
                        .HasForeignKey("CardRarityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MagicDatabase.CardStatus", "CardStatus")
                        .WithMany()
                        .HasForeignKey("CardStatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MagicDatabase.CardSubCategory", "CardSubCategory")
                        .WithMany()
                        .HasForeignKey("CardSubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardArtType");

                    b.Navigation("CardLanguage");

                    b.Navigation("CardRarity");

                    b.Navigation("CardStatus");

                    b.Navigation("CardSubCategory");
                });

            modelBuilder.Entity("MagicDatabase.CardSubCategory", b =>
                {
                    b.HasOne("MagicDatabase.CardCategory", "CardCategory")
                        .WithMany("CardSubCategories")
                        .HasForeignKey("CardCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardCategory");
                });

            modelBuilder.Entity("MagicDatabase.CardCategory", b =>
                {
                    b.Navigation("CardSubCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
