using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageBoard.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Infrastructure.Context
{
    public class MessageDbContext : DbContext
    {
        public MessageDbContext(DbContextOptions<MessageDbContext> options) : base(options)
        {

        }

        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(m => m.Id);
                
                entity.Property(m => m.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(m => m.Caption)
                    .HasMaxLength(500);

                entity.Property(m => m.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");

                entity.HasIndex(m => m.CreatedAt);

                entity.ToTable("Messages");

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
