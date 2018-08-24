using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //控制器 database first

            studentttEntities context = new studentttEntities();
            var query = (from a in context.Set<studnet>().AsNoTracking()
                         join c in context.Set<city>().AsNoTracking() on a.cityid equals c.cityid
                         orderby a.stuid
                         select new
                         {
                             a.stuid,
                             a.stuname,
                             c.cityname
                         }
                        ) as IQueryable;

            Console.WriteLine(query);
        }
    }
}
