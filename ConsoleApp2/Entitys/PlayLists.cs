using ConsoleApp2.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PlayList
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public int CategoryId { get; set; }
        public Song Song { get; set; }
        public Category Category { get; set; }
    }
}
