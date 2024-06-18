using Task2._1;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Login = "User1", Password = "87654321" };

            user.Changed += User_Changed;

            user.Login = "User2";
            user.Password = "Passwrod";
        }

        static void User_OnChanged(object? sender, EventArgs e)
        {
            Console.WriteLine($"Изменены данные пользователя со следующими логином: {((User)sender).Login}");
            Console.WriteLine($"Изменены данные пользователя со следующими паролем: {((User)sender).Password}");
        }
    }
}
