using Pr5BB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5BB
{
   
    public class Helper
    {
        private static databaseEntities1 _context;
        public static databaseEntities1 GetContext()
        {
            if (_context == null)
            {
                _context = new databaseEntities1();
            }
            return _context;

        }
        public void CreateUser(Authorization user)
        {
            _context.Authorization.Add(user); 
            _context.SaveChanges(); 
        }
        public void UpdateAuthorization(Authorization user)
        {
            _context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges(); 
        }
        public void RemoveUser(int idAuthorization)
        {
            var users = _context.Authorization.Find(idAuthorization); 
            _context.Authorization.Remove(users); 
            _context.SaveChanges(); 
        }
        public List<Authorization> FiltrUsers()
        {
            return _context.Authorization.Where(x => x.login.StartsWith("M") || x.login.StartsWith("A")).ToList();
        }
        public List<Authorization> SortUsers()
        {
            return _context.Authorization.OrderBy(x => x.login).ToList();
        }
      

    }
}
