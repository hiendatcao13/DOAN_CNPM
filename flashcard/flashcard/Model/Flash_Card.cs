using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace flashcard.Model
{
    public partial class Flash_Card : DbContext
    {
        public Flash_Card()
            : base("name=Flash_Card")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Level> Levels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(e => e.Categories)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Cards)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.Category_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Level>()
                .HasMany(e => e.Cards)
                .WithRequired(e => e.Level)
                .HasForeignKey(e => e.Level_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
