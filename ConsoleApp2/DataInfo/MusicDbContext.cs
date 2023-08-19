using ConsoleApp2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MusicDbContext : DbContext
    {

        public MusicDbContext() : base()
        {
            //this.Database.EnsureDeleted();
            // create database if does not exists
            //this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MusicDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // data initialization
            modelBuilder.Entity<Artist>().HasData(new[]
            {
                new Artist() { Id = 1, Name = "Uzi", CountryId = 1},
                new Artist() { Id = 2, Name = "Chieff Kiff" , CountryId = 2},
                new Artist() { Id = 3, Name = "Bobby Shmurda" , CountryId = 3},
                new Artist() { Id = 4, Name = "Vert", CountryId = 4 },
                new Artist() { Id = 5, Name = "Goblin" , CountryId = 5},
                new Artist() { Id = 6, Name = "Justaf" , CountryId = 6},
                new Artist() { Id = 7, Name = "Drive" , CountryId = 7},
                new Artist() { Id = 8, Name = "Juggernut" , CountryId = 8}
            });
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "United States of America"},
                new Country() { Id = 2, Name = "Canada"},
                new Country() { Id = 3, Name = "Ukraine"},
                new Country() { Id = 4, Name = "Poland"},
                new Country() { Id = 5, Name = "Germany"},
                new Country() { Id = 6, Name = "Italy"},
                new Country() { Id = 7, Name = "Spain"  },
                new Country() { Id = 8, Name = "Japan"},
            });
            modelBuilder.Entity<Album>().HasData(new[]
            {
                new Album() { Id = 1, Name = "Yupe", Year = 1987, ArtistId = 1, GenreId = 1},
                new Album() { Id = 2, Name = "Jane", Year = 2001, ArtistId = 2, GenreId = 2},
                new Album() { Id = 3, Name = "Lux", Year = 1774, ArtistId = 3, GenreId = 3},
                new Album() { Id = 4, Name = "Wex", Year = 988, ArtistId = 4, GenreId = 4},
                new Album() { Id = 5, Name = "Kvas", Year = 123, ArtistId = 5, GenreId = 5},
                new Album() { Id = 6, Name = "Octarine", Year = 1001, ArtistId = 6, GenreId = 6},
                new Album() { Id = 7, Name = "Spell Prism", Year = 1111, ArtistId = 7, GenreId = 7},
                new Album() { Id = 8, Name = "Black Hole", Year = 2223, ArtistId = 8, GenreId = 8},
            });
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "For Child"},
                new Category() { Id = 2, Name = "For Adult"},
                new Category() { Id = 3, Name = "For Grandparents"},
                new Category() { Id = 4, Name = "For Teenager"},
                new Category() { Id = 5, Name = "For Family"},
            });
            modelBuilder.Entity<Genre>().HasData(new[]
            {
                new Genre() {Id = 1, Name = "Jazz"},
                new Genre() {Id = 2, Name = "Chill"},
                new Genre() {Id = 3, Name = ""},
                new Genre() {Id = 4, Name = "Vibe"},
                new Genre() {Id = 5, Name = "Metal"},
                new Genre() {Id = 6, Name = "Hard Rock"},
                new Genre() {Id = 7, Name = "Rock"},
                new Genre() {Id = 8, Name = "EDM"},
            });

            modelBuilder.Entity<PlayList>().HasData(new[]
            {
                new PlayList() {Id = 1, CategoryId = 1, SongId = 1},
                 new PlayList() {Id = 2 ,CategoryId = 2, SongId = 2},
                 new PlayList() {Id = 3 ,CategoryId = 3, SongId = 3},
                 new PlayList() {Id = 4 ,CategoryId = 4, SongId = 4},
                 new PlayList() {Id = 5 , CategoryId = 5, SongId = 5},
            });
            modelBuilder.Entity<Song>().HasData(new[]
            {
                new Song() { Id = 1, Duration = "12:44", AlbumId = 1},
                new Song() { Id = 2, Duration = "60:71", AlbumId = 2},
                new Song() { Id = 3, Duration = "24:33", AlbumId = 3},
                new Song() { Id = 4, Duration = "1:23", AlbumId = 4},
                new Song() { Id = 5, Duration = "12:65", AlbumId = 5},
                new Song() { Id = 6, Duration = "43:77", AlbumId = 6},
            });
        }

        // Object Collections (Tables in SQL)

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categorises { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<Song> Songs { get; set; }

    }
}

