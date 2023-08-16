using System.Diagnostics.Metrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp4
{

    class Program
    {
        static void Main(string[] args)
        {
            MusicDbContext msd = new MusicDbContext();

            

            msd.SaveChanges();
        }
    }
}
