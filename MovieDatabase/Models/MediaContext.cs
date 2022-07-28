using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieDatabase.Models
{
    public class MediaContext : DbContext
    {
        public MediaContext(DbContextOptions<MediaContext> options) : base(options)
        { }
        public MediaContext() : base() { }
        public DbSet<Media> Medias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Media>().HasData(
                new Media
                {
                    MediaId = 1,
                    Title = "One Piece",
                    Genre = "Shonen",
                    Rating = 5,
                    Description = "Anime pirates"
                },
                new Media
                {
                    MediaId = 2,
                    Title = "Top Gun",
                    Genre = "Action",
                    Rating = 3,
                    Description = "Planes n shit"
                }
                );
        }
    }
}
