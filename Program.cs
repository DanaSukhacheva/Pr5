using HashPasswords;
using Pr5BB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5BB
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            databaseEntities1 db = Helper.GetContext();
            Class1 hasher = new Class1();
            /*var jobtitle = db.Jobtitles.FirstOrDefault();
            Console.WriteLine(jobtitle.title + " " + jobtitle.ID_jobtitle.ToString());*/
           
            Console.WriteLine("Оригинальный пароль: " + "Hr46hI2m");
            var personalData = db.Personal_data.Where(a => a.gmail == "zellen012@gmail.com").FirstOrDefault();
            var employee = db.Employees.Where(a => a.Personal_data.ID_personal_data == personalData.ID_personal_data).FirstOrDefault();
            Authorization authorization = new Authorization {
                ID_authorization = 6,
                login = "meneger",
                password = hasher.HashPassword("Hr46hI2m")
            };
            db.Authorization.Add(authorization);
            db.SaveChanges();
            employee.Authorization = authorization;
            db.SaveChanges();
        }
    }
}
