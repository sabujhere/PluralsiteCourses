﻿using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace SamuraiApp.Data
{
    public sealed class SamuraiContext : DbContext
    {
        //needed for the console app
        public SamuraiContext()
        {
            
        }

        public SamuraiContext(DbContextOptions<SamuraiContext> options)
        :base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<Battle> Battles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>().HasKey(s => new {s.SamuraiId, s.BattleId});
            modelBuilder.Entity<Horse>().ToTable("Horses");
        }
    }
}
