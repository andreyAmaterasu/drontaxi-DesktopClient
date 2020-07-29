using drontaxi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace drontaxi.Database
{
    class DatabaseManager
    {
        public static T GetUserWithLogin<T>(string login) where T : class {
            using (drontaxiContext db = new drontaxiContext()) {
                if (typeof(T) == typeof(Useraccount))
                    return db.Useraccount.Where(m => m.Email == login).FirstOrDefault() as T;
            }
            return null;
        }
    }
}
