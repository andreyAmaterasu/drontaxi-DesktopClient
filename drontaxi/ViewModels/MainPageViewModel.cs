using System;
using System.Collections.Generic;
using System.Text;

namespace drontaxi.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(string login) {
            Login = login;
        }

        private string login;

        //private Page currentPage;
        public string Login {
            get { return login; }
            set {
                login = value;
                OnPropertyChanged("Login");
            }
        }

    }
}
