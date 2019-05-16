using System;
using System.Linq;

namespace TestEfCoreBuggy
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var x = context.MyEntitites.Where(z => z.Id == 1).ToList();

                Console.ReadKey();
            }
        }
    }
}
