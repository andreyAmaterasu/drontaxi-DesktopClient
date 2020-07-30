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

        public static List<AvailableRoles> GetRolesForUserWithLogin(string login) {
            using (drontaxiContext db = new drontaxiContext()) {
                List<RoleForUser> roleForUsers = db.RoleForUser.Where(r => r.Email == login).ToList();
                List<AvailableRoles> availableRoles = new List<AvailableRoles>();

                foreach (RoleForUser roleForUser in roleForUsers) {
                    if (db.AvailableRoles.Where(a => a.SystemName == roleForUser.Role).FirstOrDefault() != null) {
                        availableRoles.Add(db.AvailableRoles.Where(a => a.SystemName == roleForUser.Role).FirstOrDefault());
                    }
                }

                return availableRoles;
            }
        }

        public static AvailableRoles GetFirstRoleWithLogin(string login) {
            using (drontaxiContext db = new drontaxiContext()) {
                RoleForUser roleForUser = db.RoleForUser.Where(r => r.Email == login).FirstOrDefault();
                return db.AvailableRoles.Where(a => a.SystemName == roleForUser.Role).FirstOrDefault(); ;
            }
        }

        public static List<SystemFunction> GetFunctionsForRole(string systemName) {
            using (drontaxiContext db = new drontaxiContext()) {
                return db.SystemFunction.Where(s => s.Role == systemName).ToList();
            }
        }

        public static void RemoveRole(string role, string login) {
            using (drontaxiContext db = new drontaxiContext()) {
                RoleForUser roleForUser = db.RoleForUser.Where(r => r.Role == role && r.Email == login).FirstOrDefault();
                db.RoleForUser.Remove(roleForUser);
                db.SaveChanges();
            }
        }

        public static void RemoveFunction(string systemName) {
            using (drontaxiContext db = new drontaxiContext()) {
                SystemFunction systemFunction = db.SystemFunction.Where(s => s.SystemName == systemName).FirstOrDefault();
                db.SystemFunction.Remove(systemFunction);
                db.SaveChanges();
            }
        }
    }
}
