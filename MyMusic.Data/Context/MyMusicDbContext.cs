using Microsoft.EntityFrameworkCore;
using MyMusic.Core.Models;
using MyMusic.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyMusic.Data.Context
{
    public class MyMusicDbContext : DbContext
    {
        public DbSet<Music> Musics { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<User> Users { get; set; }

        public MyMusicDbContext(DbContextOptions<MyMusicDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MusicConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder
              .ApplyConfiguration(new UserConfiguration());

        }

    }
}
