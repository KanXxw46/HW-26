using System;

namespace HW26
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataAccess = new UserDateAccess();
            dataAccess.Create(user);

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration["connectionString"];

            using (var context = new ApplicationContext(connectionString))
            {
                User user = new User
                {
                    Phone = "+87708387482984",
                    Password = "12345",
                    Email = "1kan_andrei@mail.ru"
                };

                var isUser = bool.Parse(configuration["isUser"]);


            }
            using (var context = new ApplicationContext(connectionString))
            {
                var userCount = context.Users.Count();
                context.SaveChanges();

                const int USERS_PER_PAGE = 3;
                var usersFirstPage = context.Users.Take(USERS_PER_PAGE).ToList();
                var usersSecondPage = context.Users.Skip(USERS_PER_PAGE).Take(USERS_PER_PAGE).ToList();

            }
        }
    }
}
