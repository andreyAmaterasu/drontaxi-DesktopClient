using drontaxi.Models;
using drontaxi.ViewModels;
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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page, INotifyPropertyChanged
    {
        public RegistrationPage() {
            InitializeComponent();
            DataContext = this;
        }

        private Useraccount createdUseraccount = new Useraccount();
        public Useraccount CreatedUseraccount {
            get { return createdUseraccount; }
            set {
                createdUseraccount = value;
                OnPropertyChanged("CreatedUseraccount");
            }
        }

        private RelayCommand registrationCommand;
        public RelayCommand RegistrationCommand {
            get {
                return registrationCommand ??
                  (registrationCommand = new RelayCommand(obj => {
                      using (drontaxiContext db = new drontaxiContext()) {
                          Useraccount useraccount = db.Useraccount.Where(u => u.Email == CreatedUseraccount.Email).FirstOrDefault();
                          if (useraccount == null) {
                              db.Useraccount.Add(createdUseraccount);
                              db.SaveChanges();
                              ShowMassage = true;
                          }
                          else {
                              ShowError = true;
                          }
                      }
                  }));
            }
        }

        private RelayCommand backToLoginPage;
        public RelayCommand BackToLoginPage {
            get {
                return backToLoginPage ??
                  (backToLoginPage = new RelayCommand(obj => {
                      LoginPage loginPage = new LoginPage();
                      NavigationService.Navigate(loginPage);
                  }));
            }
        }

        private bool showMassage;
        public bool ShowMassage {
            get { return showMassage; }
            set {
                showMassage = value;
                OnPropertyChanged("ShowMassage");
            }
        }

        private bool showError;
        public bool ShowError {
            get { return showError; }
            set {
                showError = value;
                OnPropertyChanged("ShowError");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "") {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
