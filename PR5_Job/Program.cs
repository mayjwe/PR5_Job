using PasswordHasher;
using PR5_Job.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace PR5_Job
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var helper = new Helper();
            var hasher = new Class1();

            Console.WriteLine("Создание новой учетной записи для пользователя");

            Console.Write("Введите роль 1 - сотрудник, 2 - клиент: ");
            int id_autho = int.Parse(Console.ReadLine());

            Console.Write("Введите имя пользователя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите фамилию пользователя: ");
            string surname = Console.ReadLine();

            Console.Write("Введите отчество пользователя (если есть): ");
            string patr = Console.ReadLine();

            Console.Write("Введите mail пользователя: ");
            string mail = Console.ReadLine();

            Console.Write("Введите номер телефона пользователя: ");
            int phone = int.Parse(Console.ReadLine());

            Console.Write("Введите пароль пользователя: ");
            string password = Console.ReadLine();

            Clients newClients = new Clients
            {
                ID_Authorization = id_autho,
                Name = firstName,
                Surname = surname,
                Patronymic = patr,
                Mail = mail,
                Phone_number = phone,
                Password = password,
            };

            Console.WriteLine($"Хешированный пароль: " + hasher.PasswordHash(password));

            helper.CreateClients(newClients);

            Console.WriteLine("Учетная запись добавлена");
        }
    }
}
