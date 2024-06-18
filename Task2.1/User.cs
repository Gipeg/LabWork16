using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    internal class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string login;
        private string password;

        public string Login
        {
            get => login;
            set
            {
                if (login != value && !string.IsNullOrWhiteSpace(value))
                {
                    login = value;
                    OnChanged();
                }
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (password != value && !string.IsNullOrWhiteSpace(value))
                {
                    password = value;
                    OnChanged();
                }
            }
        }

        public event EventHandler Changed;
        public void OnChanged()
        {
            Changed?.Invoke(this, EventArgs.Empty); 
        }
    }
}
