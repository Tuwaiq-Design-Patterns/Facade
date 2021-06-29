using System;

namespace FacadeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your username");
            string username = Console.ReadLine();
            Console.WriteLine("Type your E-mail");
            string email = Console.ReadLine();
            Console.WriteLine("Type your password");
            string password = Console.ReadLine();
            Console.WriteLine("Type your phone number");
            string phonenumber = Console.ReadLine();

            // Use Facade
            AuthFacade.Register(username, email, password, phonenumber);

            Console.ReadKey();
        }
    }
    
    public class AuthFacade
    {
        public static void Register(string username, string email, string password, string phonenumber)
        {
            User user = new User()
            {
                UserName = username,
                Email = email,
                Password = password,
                PhoneNumber = phonenumber
            };
            Authenticator.Register(user);
            int token = Authenticator.Login(user.Email, user.Password);
            Authenticator.SendEmailConfirmation(user);
        }
        public static void Login(string email, string password)
        {
            Authenticator.Login(email, password);
        }
    }
    public static class Authenticator
    {
        public static void Register(User user)
        {
            Console.WriteLine($"{user.UserName} registered successfully!");
        }
        public static int Login(string email, string password)
        {
            Console.WriteLine($"{email} has logged in successfully.");
            return HashCode.Combine(email, password);
        }
        public static bool IsUserLockedout(int token)
        {
            User user = Authenticator.GetUserByToken(token);
            return user.LockedoutEnabled;
        }
        public static void AddTwoFactorAuth(int token, string authType)
        {
            User user = Authenticator.GetUserByToken(token);
            if (authType == "PhoneNumber")
                Console.WriteLine($"Phone number '{user.PhoneNumber}' two factor authenticator added successfully.");
            else if (authType == "Email")
                Console.WriteLine($"E-mail '{user.Email}' two factor authenticator added successfully.");
            else
                Console.WriteLine($"{authType} is a not supported two factor authenticator");
        }
        public static User GetUserByToken(int token)
        {
            return new User();
        }
        public static void SendEmailConfirmation(User user)
        {
            Console.WriteLine($"E-mail confirmation sent to {user.Email}");
        }
    }
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool LockedoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
    }
}