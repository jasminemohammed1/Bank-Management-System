using GNET14_EF03_EF04.models;
using Microsoft.EntityFrameworkCore;

namespace GNET14_EF03_EF04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbcontext = new DBContextBankApp();
            #region Sead data
            //dbcontext.Database.Migrate();
            //if(!dbcontext.Set<Manager>().Any())
            //{
            //    var manager1 = new Manager()
            //    {
            //        FullName = "Ahmed Mohamed Ali",
            //        Email = "Ahmed@gmail.com",
            //        PhoneNumber = "0123456789"
            //    };
            //    var manager2 = new Manager()
            //    {
            //        FullName = "Menna Mohamed Elsaid",
            //        Email = "Menna12@gmail.com",
            //        PhoneNumber = "0123456789"
            //    };
            //    var manager3 = new Manager()
            //    {
            //        FullName = "Abdullah Mohamed",
            //        Email = "Abdullah@gmail.com",
            //        PhoneNumber = "0123467899"
            //    };

            //    dbcontext.AddRange(manager1, manager2, manager3);
            //    int affectedRows = dbcontext.SaveChanges();
            //    if(affectedRows !=0)
            //    {
            //        Console.WriteLine("Data Saeded Sucessfully at Manager");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No Data Seaded");
            //    }

            //}

            //if(!dbcontext.Set<Branch>().Any())
            //{
            //    var Branch1 = new Branch()
            //    {
            //        ManagerId = 1,
            //        PhoneNumber = "1234567",
            //        Name = "Obour Branch",
            //        Address = "Obour Cairo",

            //    };

            //    var Branch2 = new Branch()
            //    {
            //        ManagerId = 2,
            //        PhoneNumber = "1234567",
            //        Name = "Dokii Branch",
            //        Address = "Dokii Cairo"
            //    };

            //    var Branch3 = new Branch()
            //    {
            //        ManagerId = 3,
            //        PhoneNumber = "3456789",
            //        Name = "Alex Branch",
            //        Address = "Alex Eygpt"
            //    };
            //    dbcontext.AddRange(Branch1, Branch2, Branch3);  
            //    int affected = dbcontext.SaveChanges();
            //    if(affected!=0)
            //    {
            //        Console.WriteLine("Data Seaded Sucessfully at Branch");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No Data Seaded");
            //    }
            //}
            #endregion
        }
    }
}
