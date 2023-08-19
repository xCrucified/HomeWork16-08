using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PlayList
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int SongId { get; set; }

        public Category Category { get; set; }
        public Song Song { get; set; }
    }

}
