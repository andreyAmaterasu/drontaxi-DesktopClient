using drontaxi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace drontaxi.View
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page, INotifyPropertyChanged
    {
        public LoginPage() {
            InitializeComponent();
            DataContext = this;
        }

        private string login;
        private string password;
        private bool showError;

        public bool ShowError {
            get { return showError; }
            set {
                showError = value;
                OnPropertyChanged("ShowError");
            }
        }

        public string Login {
            get { return login; }
            set {
                login = value;
                OnPropertyChanged("Login");
            }
        }
        public string Password {
            get { return password; }
            set {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private RelayCommand entryCommand;
        public RelayCommand EntryCommand {
            get {
                return entryCommand ??
                  (entryCommand = new RelayCommand(obj => {
                      Password = inputPassword.Password;
                      Useraccount useraccount = new Useraccount();
                      using (drontaxiContext db = new drontaxiContext()) {
                          try {
                              useraccount = db.Useraccount.Where(m => m.Email == login).FirstOrDefault();
                          }
                          catch (InvalidOperationException ex) {
                              ShowError = true;
                          }
                      }
                      //Useraccount useraccount = (Useraccount)Database.DatabaseManager.GetUserWithLogin<Useraccount>(Login);
                      if (useraccount != null && useraccount.Email == Login && useraccount.Password == Password) {
                          MainPage mainPage = new MainPage(Login);
                          ProfilePage profilePage = new View.ProfilePage(Login);
                          MainPage.CurrentPage.Content = profilePage;

                          NavigationService.Navigate(mainPage);
                      }
                  }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "") {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
