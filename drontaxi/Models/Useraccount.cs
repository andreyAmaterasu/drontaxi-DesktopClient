using drontaxi.ViewModels;
using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class Useraccount : BaseViewModel
    {
        public Useraccount()
        {
            OrderOfUserCustomerNavigation = new HashSet<OrderOfUser>();
            OrderOfUserOperatorNavigation = new HashSet<OrderOfUser>();
            RoleForUser = new HashSet<RoleForUser>();
            SaveUseraccount = new HashSet<SaveUseraccount>();
        }

        private string email;
        private string password;
        private string lastname;
        private string firstname;
        private string patronymic;
        private DateTime? dateOfBirth;
        private string gender;
        private string phoneNumber;
        private string photo;

        public string Email { 
            get { return email; }
            set {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        public string Password {
            get { return password; }
            set {
                password = value;
                OnPropertyChanged("Password");
            }
        }
        public string Lastname {
            get { return lastname; }
            set {
                lastname = value;
                OnPropertyChanged("Lastname");
            }
        }
        public string Firstname {
            get { return firstname; }
            set {
                firstname = value;
                OnPropertyChanged("Firstname");
            }
        }
        public string Patronymic { 
            get { return patronymic; }
            set {
                patronymic = value;
                OnPropertyChanged("Patronymic");
            }
        }
        public DateTime? DateOfBirth { 
            get { return dateOfBirth; }
            set {
                dateOfBirth = value;
                OnPropertyChanged("");
            }
        }
        public string Gender { 
            get { return gender; }
            set {
                gender = value;
                OnPropertyChanged("Gender");
            }
        }
        public string PhoneNumber { 
            get { return phoneNumber; }
            set {
                phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }
        public string Photo { 
            get { return photo; }
            set {
                photo = value;
                OnPropertyChanged("Photo");
            }
        }

        //public string Email { get; set; }
        //public string Password { get; set; }
        //public string Lastname { get; set; }
        //public string Firstname { get; set; }
        //public string Patronymic { get; set; }
        //public DateTime? DateOfBirth { get; set; }
        //public string Gender { get; set; }
        //public string PhoneNumber { get; set; }
        //public string Photo { get; set; }

        public virtual ICollection<OrderOfUser> OrderOfUserCustomerNavigation { get; set; }
        public virtual ICollection<OrderOfUser> OrderOfUserOperatorNavigation { get; set; }
        public virtual ICollection<RoleForUser> RoleForUser { get; set; }
        public virtual ICollection<SaveUseraccount> SaveUseraccount { get; set; }
    }
}
