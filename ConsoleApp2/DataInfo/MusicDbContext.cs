using ConsoleApp2.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MusicDbContext : DbContext
    {
        public MusicDbContext() : base()
        {
            //this.Database.EnsureDeleted();
            // create database if does not exists
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string conn = "Data Source=(localdb)\\ProjectModels;Initial Catalog=MusicDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // data initialization
            modelBuilder.Entity<Artist>().HasData(new[]
            {
                new Artist() { Id = 1, Name = "Uzi"},
                new Artist() { Id = 2, Name = "Chieff Kiff" },
                new Artist() { Id = 3, Name = "Bobby Shmurda" },
                new Artist() { Id = 4, Name = "Vert" },
                new Artist() { Id = 5, Name = "Goblin" },
                new Artist() { Id = 6, Name = "Justaf" },
                new Artist() { Id = 7, Name = "Drive" },
                new Artist() { Id = 8, Name = "Juggernut" }
            });
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "United States of America"},
                new Country() { Id = 2, Name = "Canada"},
                new Country() { Id = 3, Name = "Ukraine"},
                new Country() { Id = 4, Name = "Poland"},
                new Country() { Id = 5, Name = "Germany"},
                new Country() { Id = 6, Name = "Italy"},
                new Country() { Id = 7, Name = "Spain"},
                new Country() { Id = 8, Name = "Japan"},
            });
            modelBuilder.Entity<Album>().HasData(new[]
            {
                new Album() { Id = 1, Name = "Yupe", Year = 1987, ArtistId = 1},
                new Album() { Id = 2, Name = "Jane", Year = 2001, ArtistId = 2},
                new Album() { Id = 3, Name = "Lux", Year = 1774, ArtistId = 3},
                new Album() { Id = 4, Name = "Wex", Year = 988, ArtistId = 4},
                new Album() { Id = 5, Name = "Kvas", Year = 123, ArtistId = 5},
                new Album() { Id = 6, Name = "Octarine", Year = 1001, ArtistId = 6},
                new Album() { Id = 7, Name = "Spell Prism", Year = 1111, ArtistId = 7},
                new Album() { Id = 8, Name = "Black Hole", Year = 2223, ArtistId = 8},
            });
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "For Child"},
                new Category() { Id = 2, Name = "For Adult"},
                new Category() { Id = 3, Name = "For Grandparents"},
            });
            modelBuilder.Entity<Genre>().HasData(new[]
            {
                new Genre() {Id = 1, Name = "Jazz"},
                new Genre() {Id = 2, Name = "Chill"},
                new Genre() {Id = 3, Name = "Rock"},
                new Genre() {Id = 4, Name = "Vibe"},
                new Genre() {Id = 5, Name = "Metal"},
                new Genre() {Id = 6, Name = "Hard Rock"},
            });
            modelBuilder.Entity<PlayList>().HasData(new[]
            {
                new PlayList() { Id = 1},
                 new PlayList() { Id = 2},
                  new PlayList() { Id = 3},
                   new PlayList() { Id = 4},
                    new PlayList() { Id = 5},
            });
            modelBuilder.Entity<Song>().HasData(new[]
            {
                new Song() { Id = 1, Duration = "12:44"},
                new Song() { Id = 2, Duration = "60:71"},
                new Song() { Id = 3, Duration = "24:33"},
                new Song() { Id = 4, Duration = "1:23"},
                new Song() { Id = 5, Duration = "12:65"},
                new Song() { Id = 6, Duration = "43:77"},
            });
        }

        // Object Collections (Tables in SQL)

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Category> Categorises { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<Song> Songs { get; set; }



    }
}

