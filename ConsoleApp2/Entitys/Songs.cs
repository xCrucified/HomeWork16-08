using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Song
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string Duration { get; set; }

        public Album Album { get; set; }
        public List<PlayList> PlayLists { get; set; }
    }
}
