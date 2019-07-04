using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct2
{
    struct User
    { 
        public static string MakeLogin() //Создайте метод, который генерирует логин. Допустимые символы a-z, A-Z. Максимальное количество сиволов в логине 5-16
        { 
            return "";
        }

        public static string MakePassword() //Создайте метод, который генерирует пароль. Допустимые символы a-z, A-Z,1-9, Максимальное количество символов в пароле 7-20
        {
            return "";
        }

        string login;
        string Password;

        public User(string login, string password)
        {
            this.login = login;
            Password = password;
        }

        //TODO создайте метод string SaveUser(), чтобы возвратить строку пользователя вида "
        //login - password", где пароль - зашифрованный.
        //Зашифровать пароль с помощью метода GetHashCode()

    }


    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine()); //TODO обработайте все исключения
            User[] users = new User[n];

            for (int i = 0; i < n; i++)
            {
                users[i] = new User(User.MakeLogin(), User.MakePassword());
            }

            string fileName = Console.ReadLine();//название файла. Проверьте его на недопустимые символы.

            //TODO Сохраните всех пользователей в файл, находящийся в каталоге с решением. Используйте адаптеры потока.
            
           
        }
    }
}
