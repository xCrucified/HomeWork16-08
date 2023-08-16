using ConsoleApp2.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public int Year { get; set; }
        public int GenreId { get; set; }
        public Artist Artist { get; set; }
        public Genre Genre { get; set; }

    }
}
