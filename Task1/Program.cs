namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Login = "User1", Password = "87654321" };

            user.PropertyChanged += User_PropertyChanged;

            user.Login = "User2";
            user.Password = "Passwrod";
        }

        static void User_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine($"{e.PropertyName} изменено");
        }
    }
}