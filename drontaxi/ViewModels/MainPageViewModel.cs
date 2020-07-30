using drontaxi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace drontaxi.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(string login) {
            Login = login;

            using (drontaxiContext db = new drontaxiContext()) {
                if (db.RoleForUser.Where(r => r.Email == Login && r.Role == "manager").FirstOrDefault() != null) {
                    ShowUserControl = true;
                }
                else {
                    ShowUserControl = false;
                }

                if (db.RoleForUser.Where(r => r.Email == Login && r.Role == "admin").FirstOrDefault() != null) {
                    ShowRoleControl = true;
                }
                else {
                    ShowRoleControl = false;
                }
            }
        }

        private string login;
        private bool showUserControl;
        private bool showRoleControl;

        //private Page currentPage;
        public string Login {
            get { return login; }
            set {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        public bool ShowUserControl {
            get { return showUserControl; }
            set {
                showUserControl = value;
                OnPropertyChanged("ShowUserControl");
            }
        }

        public bool ShowRoleControl {
            get { return showRoleControl; }
            set {
                showRoleControl = value;
                OnPropertyChanged("ShowRoleControl");
            }
        }
    }
}
