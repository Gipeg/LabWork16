using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Task1
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
                    OnPropertyChanged();
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
                    OnPropertyChanged();
                }
            }
        }

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}