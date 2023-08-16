using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entitys
{
    internal class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Album Album { get; set; }
    }
}
