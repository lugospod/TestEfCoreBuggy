using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TestEfCoreBuggy
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var data = context.Templates.Include(x => x.Parts).ToList();

                Console.ReadKey();
            }
        }
    }
}
