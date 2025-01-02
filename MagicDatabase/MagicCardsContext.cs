using MagicDatabase;
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
        public DbSet<CardRarity> CardRarities { get; set; }

        // Tabella CardStatus
        public DbSet<CardStatus> CardStatuses { get; set; }

        // Tabella CardCategory
        public DbSet<CardCategory> CardCategories { get; set; }

        // Tabella CardLanguage
        public DbSet<CardLanguage> CardLanguages { get; set; }

        // Tabella CardArtType
        public DbSet<CardArtType> CardArtTypes { get; set; }


        // Configurazione tramite Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura la tabella Cards
            modelBuilder.Entity<Card>(entity =>
            {
                entity.ToTable("Cards"); // Nome tabella
                entity.HasKey(c => c.CardId); // Chiave primaria
                entity.Property(c => c.CardName).IsRequired().HasMaxLength(255); // Nome obbligatorio
                entity.HasOne(c => c.CardRarity); // Relazione con CardRarity
                entity.HasOne(c => c.CardStatus); // Relazione con CardStatus
                entity.HasOne(c => c.CardCategory); // Relazione con CardCategory
                entity.HasOne(c => c.CardLanguage); // Relazione con CardLanguage
                entity.HasOne(c => c.CardArtType); // Relazione con CardArtType

            });

            // Configura la tabella CardRarity
            modelBuilder.Entity<CardRarity>(entity =>
            {
                entity.ToTable("CardRarity");
                entity.HasKey(r => r.CardRarityId);
                entity.Property(r => r.CardRarityName).IsRequired().HasMaxLength(100);
            });

            // Configura la tabella CardStatus
            modelBuilder.Entity<CardStatus>(entity =>
            {
                entity.ToTable("CardStatus");
                entity.HasKey(s => s.CardStatusId);
                entity.Property(s => s.CardStatusName).IsRequired().HasMaxLength(100);
            });

            // Configura la tabella CardCategory
            modelBuilder.Entity<CardCategory>(entity =>
            {
                entity.ToTable("CardRarity");
                entity.HasKey(r => r.CardCategoryId);
                entity.Property(r => r.CardCategoryName).IsRequired().HasMaxLength(100);
            });

            // Configura la tabella CardLanguage
            modelBuilder.Entity<CardLanguage>(entity =>
            {
                entity.ToTable("CardLanguage");
                entity.HasKey(l => l.CardLanguageId);
                entity.Property(l => l.CardLanguageName).IsRequired().HasMaxLength(100);
            });

            // Configura la tabella CardArtType
            modelBuilder.Entity<CardArtType>(entity =>
            {
                entity.ToTable("CardArtType");
                entity.HasKey(a => a.CardArtTypeId);
                entity.Property(a => a.CardArtTypeName).IsRequired().HasMaxLength(100);
            });
        }
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
    }
}
