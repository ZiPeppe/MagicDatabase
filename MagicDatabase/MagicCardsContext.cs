using MagicDatabase.Models;
using MagicDatabase.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MagicCardsAPI.Data
{
    public class MagicCardsContext : DbContext
    {
        public MagicCardsContext(DbContextOptions<MagicCardsContext> options)
            : base(options)
        {
        }

        // Tabella Cards
        public DbSet<Card> Cards { get; set; }

        // Tabella CardRarity
        public DbSet<CardRarity> CardRarity { get; set; }

        // Tabella CardStatus
        public DbSet<CardStatus> CardStatus { get; set; }

        // Tabella CardCategory
        public DbSet<CardCategory> CardCategory { get; set; }

        // Tabella CardLanguage
        public DbSet<CardLanguage> CardLanguage { get; set; }

        // Tabella CardArtType
        public DbSet<CardArtType> CardArtType { get; set; }

        //Tabella Users
        public DbSet<User> Users { get; set; }

        // Tabella RefreshTokens
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Usa il seed data della classe UserSeed
            UserSeed.SeedUsers(modelBuilder);

            // Configurazione della tabella CardCategory
            modelBuilder.Entity<CardCategory>(entity =>
            {
                entity.ToTable("CardCategories");
                entity.HasKey(c => c.CardCategoryId);
                entity.Property(c => c.CardCategoryName).IsRequired().HasMaxLength(100);

                // Aggiungi il seed da classe esterna
                entity.HasData(CardCategorySeed.GetData());
            });

            // Configurazione della tabella CardSubCategory
            modelBuilder.Entity<CardSubCategory>(entity =>
            {
                entity.ToTable("CardSubCategories");
                entity.HasKey(sc => sc.CardSubCategoryId);

                // Relazione con CardCategory
                entity.HasOne(sc => sc.CardCategory)
                    .WithMany(c => c.CardSubCategories)
                    .HasForeignKey(sc => sc.CardCategoryID);

                // Aggiungi il seed da classe esterna
                entity.HasData(CardSubCategorySeed.GetData());
            });

            // Configurazioni per la tabella Cards
            modelBuilder.Entity<Card>(entity =>
            {
                entity.ToTable("Cards");
                entity.HasKey(c => c.CardId);
                entity.Property(c => c.CardName).IsRequired().HasMaxLength(255);

                // Relazioni
                entity.HasOne(c => c.CardArtType)
                    .WithMany()
                    .HasForeignKey(c => c.CardArtTypeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(c => c.CardLanguage)
                    .WithMany()
                    .HasForeignKey(c => c.CardLanguageId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(c => c.CardStatus)
                    .WithMany()
                    .HasForeignKey(c => c.CardStatusId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(c => c.CardRarity)
                    .WithMany()
                    .HasForeignKey(c => c.CardRarityId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Configurazioni per la tabella CardArtType
            modelBuilder.Entity<CardArtType>(entity =>
            {
                entity.ToTable("CardArtTypes");
                entity.HasKey(a => a.CardArtTypeId);
                entity.Property(a => a.CardArtTypeName).IsRequired().HasMaxLength(100);

                // Seed data
                entity.HasData(CardArtTypeSeed.GetData());
            });

            // Configurazioni per la tabella CardLanguage
            modelBuilder.Entity<CardLanguage>(entity =>
            {
                entity.ToTable("CardLanguages");
                entity.HasKey(l => l.CardLanguageId);
                entity.Property(l => l.CardLanguageName).IsRequired().HasMaxLength(100);

                // Seed data
                entity.HasData(CardLanguageSeed.GetData());
            });

            // Configurazioni per la tabella CardStatus
            modelBuilder.Entity<CardStatus>(entity =>
            {
                entity.ToTable("CardStatuses");
                entity.HasKey(s => s.CardStatusId);
                entity.Property(s => s.CardStatusName).IsRequired().HasMaxLength(100);

                // Seed data
                entity.HasData(CardStatusSeed.GetData());
            });

            // Configurazioni per la tabella CardRarity
            modelBuilder.Entity<CardRarity>(entity =>
            {
                entity.ToTable("CardRarities");
                entity.HasKey(r => r.CardRarityId);
                entity.Property(r => r.CardRarityName).IsRequired().HasMaxLength(100);

                // Seed data
                entity.HasData(CardRaritySeed.GetData());
            });
        }
    }
}
        //// Configurazione tramite Fluent API
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configura la tabella Cards
        //    modelBuilder.Entity<Card>(entity =>
        //    {
        //        entity.ToTable("Cards"); // Nome tabella
        //        entity.HasKey(c => c.CardId); // Chiave primaria
        //        entity.Property(c => c.CardName)
        //        .IsRequired()
        //        .HasMaxLength(255); // Nome obbligatorio
        //        entity.HasOne(c => c.CardRarity); // Relazione con CardRarity
        //        entity.HasOne(c => c.CardStatus); // Relazione con CardStatus
        //        entity.HasOne(c => c.CardCategory); // Relazione con CardCategory
        //        entity.HasOne(c => c.CardLanguage); // Relazione con CardLanguage
        //        entity.HasOne(c => c.CardArtType); // Relazione con CardArtType

        //    });

        //    // Configura la tabella CardRarity
        //    modelBuilder.Entity<CardRarity>(entity =>
        //    {
        //        entity.ToTable("CardRarity");
        //        entity.HasKey(r => r.CardRarityId);
        //        entity.Property(r => r.CardRarityName)
        //        .IsRequired()
        //        .HasMaxLength(100);
        //    });

        //    // Configura la tabella CardStatus
        //    modelBuilder.Entity<CardStatus>(entity =>
        //    {
        //        entity.ToTable("CardStatus");
        //        entity.HasKey(s => s.CardStatusId);
        //        entity.Property(s => s.CardStatusName)
        //        .IsRequired()
        //        .HasMaxLength(100);
        //    });

        //    // Configura la tabella CardCategory
        //    modelBuilder.Entity<CardCategory>(entity =>
        //    {
        //        entity.ToTable("CardCategory");
        //        entity.HasKey(r => r.CardCategoryId);
        //        entity.Property(r => r.CardCategoryName)
        //        .IsRequired()
        //        .HasMaxLength(100);
        //    });

        //    // Configura la tabella CardLanguage
        //    modelBuilder.Entity<CardLanguage>(entity =>
        //    {
        //        entity.ToTable("CardLanguage");
        //        entity.HasKey(l => l.CardLanguageId);
        //        entity.Property(l => l.CardLanguageName)
        //        .IsRequired()
        //        .HasMaxLength(100);
        //    });

        //    // Configura la tabella CardArtType
        //    modelBuilder.Entity<CardArtType>(entity =>
        //    {
        //        entity.ToTable("CardArtType");
        //        entity.HasKey(a => a.CardArtTypeId);
        //        entity.Property(a => a.CardArtTypeName)
        //        .IsRequired()
        //        .HasMaxLength(100);
        //    });
        //}

        /*public class MagicDbContext : DbContext
        {
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Configura la tabella Card
                modelBuilder.Entity<Card>()
                    .ToTable("Cards") // Mappa l'entità Card alla tabella "Cards"
                    .HasKey(c => c.CardId); // Imposta CardId come chiave primaria

                // Configura la relazione con CardRarity
                modelBuilder.Entity<Card>()
                    .HasOne(c => c.CardRarity) // Una Card ha una CardRarity
                    .WithMany() // Una CardRarity può essere associata a più Card
                    .HasForeignKey(c => c.CardRarityId) // Chiave esterna nella tabella Card
                    .OnDelete(DeleteBehavior.Restrict); // Evita la cancellazione a cascata

                // Configura la relazione con CardCategory
                modelBuilder.Entity<Card>()
                    .HasOne(c => c.CardCategory) // Una Card ha una CardCategory
                    .WithMany() // Una CardCategory può essere associata a più Card
                    .HasForeignKey(c => c.CardCategoryId) // Chiave esterna nella tabella Card
                    .OnDelete(DeleteBehavior.Restrict); // Evita la cancellazione a cascata

                // Configura CardRarity
                modelBuilder.Entity<CardRarity>()
                    .ToTable("CardRarity") // Mappa l'entità alla tabella "CardRarity"
                    .HasKey(cr => cr.CardRarityId); // Imposta Id come chiave primaria

                // Configura CardCategory
                modelBuilder.Entity<CardCategory>()
                    .ToTable("CardCategory") // Mappa l'entità alla tabella "CardCategory"
                    .HasKey(cc => cc.CardCategoryId); // Imposta Id come chiave primaria
            }
        }*/


        //public class MagicCardsContext : DbContext
        //{
        //    public MagicCardsContext(DbContextOptions<MagicCardsContext> options) : base(options) { }

        //    public DbSet<Card> Cards { get; set; }
        //    public DbSet<CardRarity> CardRarities { get; set; }
        //    public DbSet<CardStatus> CardStatuses { get; set; }
        //    public DbSet<CardArtType> CardArtTypes { get; set; }
        //    public DbSet<CardCategory> CardCategories { get; set; }
        //    public DbSet<CardLanguage> CardLanguages { get; set; }

        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<Card>()
        //            .HasOne(c => c.CardRarity)
        //            .WithMany()
        //            .HasForeignKey(c => c.CardRarityId);

        //        modelBuilder.Entity<Card>()
        //            .HasOne(c => c.CardStatus)
        //            .WithMany()
        //            .HasForeignKey(c => c.CardStatusId);
        //    }
        //}

