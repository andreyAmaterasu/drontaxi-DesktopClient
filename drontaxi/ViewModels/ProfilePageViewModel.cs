using System;
using System.Collections.Generic;
using System.Text;

namespace drontaxi.ViewModels
{
    class ProfilePageViewModel : BaseViewModel
    {
        public ProfilePageViewModel(string login) {
            Login = login;
        }

        private string login;
        public string Login {
            get { return login; }
            set {
                login = value;
                OnPropertyChanged("Login");
            }
        }
    }
}
