using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entitys
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PlayList PlayList { get; set; }
    }
}
