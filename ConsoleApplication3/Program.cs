using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbHelp.Base;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            DbBase<Person> db = new DbBase<Person>();
            var model = new Person()
            {
                LastName = "last",
                FirstName = "first",
                HireDate = DateTime.Now,
                EnrollmentDate = DateTime.Now,
                Discriminator = "djf"
            };
            db.Insert(model);
            db.SaveChanges();

           

            var account = db.FindById(1);
            Console.WriteLine(account.FirstName);

          
        }
    }
}
