using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Anket1.Models
{
    public class User : INotifyPropertyChanged

    {

        private string _name { get; set; }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string _surname { get; set; }
        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }

        private string _fatherName { get; set; }
        public string FatherName
        {
            get => _fatherName;
            set
            {
                _fatherName = value;
                OnPropertyChanged();
            }
        }

        private string _phone { get; set; }
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        private string _gender { get; set; }
        public string Gender
        {
            get => _gender;
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }
        private DateTime _birthDay { get; set; }
        public DateTime BirthDay
        {
            get => _birthDay;
            set
            {
                _birthDay = value;
                OnPropertyChanged();
            }
        }




    }
}
