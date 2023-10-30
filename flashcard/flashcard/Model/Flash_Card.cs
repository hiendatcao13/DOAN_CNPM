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

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Level> Level { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(e => e.Category)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Card)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.Category_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Level>()
                .HasMany(e => e.Card)
                .WithRequired(e => e.Level)
                .HasForeignKey(e => e.Level_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
