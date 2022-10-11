
using Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Domain.Context
{
    public class ChatContext : DbContext
    {
        public ChatContext(DbContextOptions<ChatContext> options) : base(options)
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ChatContext, ChatApi.Migrations.Configuration>());
            
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // User Mapping
            modelBuilder.Entity<User>()
                .HasKey(r => r.UserID);

            modelBuilder.Entity<User>()
                .Property(r => r.FirstName).IsRequired();

            modelBuilder.Entity<User>()
                .Property(r => r.LastName).IsRequired();

            modelBuilder.Entity<User>()
                .Property(r => r.Email).IsRequired();

            // Message Mapping
            modelBuilder.Entity<Message>()
                .HasKey(r => r.MessageID);

            modelBuilder.Entity<Message>()
                .Property(r => r.SentAt).IsRequired();

            modelBuilder.Entity<Message>()
                .Property(r => r.ReadAt).IsRequired();

            modelBuilder.Entity<Message>()
                .Property(r => r.Content).IsRequired();

            //UserMessage Mapping
            modelBuilder.Entity<UserMessage>()
                .HasKey(r => r.ID);

            modelBuilder.Entity<UserMessage>()
                .HasOne(u => u.SenderUser)
                .WithMany(um => um.SenderMessages)
                .HasForeignKey(um => um.SenderID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserMessage>()
                .HasOne(u => u.ReceiverUser)
                .WithMany(um => um.ReceiverMessages)
                .HasForeignKey(um => um.ReceiverID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserMessage>()
                .HasOne(u => u.Message)
                .WithMany(um => um.Messages)
                .HasForeignKey(um => um.MessageID)
                .OnDelete(DeleteBehavior.NoAction);

            //new DbInitializer(modelBuilder).Seed();
        }
    }
}
