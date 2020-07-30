using drontaxi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drontaxi.ViewModels
{
    class ProfilePageViewModel : BaseViewModel
    {
        public ProfilePageViewModel(string login) {
            Login = login;
            RoleForUser = Database.DatabaseManager.GetRolesForUserWithLogin(Login);
        }

        private string login;
        private Useraccount useraccount = new Useraccount();
        private AvailableRoles selectedRole = new AvailableRoles();
        private List<SystemFunction> functionsForRole;
        private List<AvailableRoles> roleForUser;

        public string Login {
            get { return login; }
            set {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        public AvailableRoles SelectedRole {
            get { return selectedRole; }
            set {
                selectedRole = value;
                OnPropertyChanged("SelectedRole");
                if (SelectedRole != null) {
                    FunctionsForRole = Database.DatabaseManager.GetFunctionsForRole(SelectedRole.SystemName);
                }
            }
        }

        public Useraccount Useraccount {
            get { return Database.DatabaseManager.GetUserWithLogin<Useraccount>(Login); }
        }

        public List<AvailableRoles> RoleForUser {
            get { return roleForUser; }
            set {
                roleForUser = value;
                OnPropertyChanged("RoleForUser");
            }
        }

        public List<SystemFunction> FunctionsForRole {
            get { return functionsForRole; }
            set {
                functionsForRole = value;
                OnPropertyChanged("FunctionsForRole");
            }
        }

        private RelayCommand removeRole;
        public RelayCommand RemoveRole {
            get {
                return removeRole ??
                    (removeRole = new RelayCommand(obj => {
                        string systemName = obj.ToString();
                        Database.DatabaseManager.RemoveRole(systemName, Login);
                        RoleForUser = Database.DatabaseManager.GetRolesForUserWithLogin(Login);
                    }));
            }
        }

        //private RelayCommand removeFunction;
        //public RelayCommand RemoveFunction {
        //    get {
        //        return removeFunction ??
        //            (removeFunction = new RelayCommand(obj => {
        //                string systemName = obj.ToString();
        //                Database.DatabaseManager.RemoveFunction(systemName);
        //                FunctionsForRole = Database.DatabaseManager.GetFunctionsForRole(SelectedRole.SystemName);
        //            }));

        //    }
        //}
    }
}
