using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_me
{
    public class MenuLogin : MathQuiz
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DateOfBirth { get; set; }
        public string Number {  get; set; }

        public MenuLogin() { }

        public MenuLogin (string userName, string password, string dateOfBirth, string number)
        {
            UserName = userName;
            Password = password;
            DateOfBirth = dateOfBirth;
            Number = number;
        }  
        
        public void LoginInfo ()
        {
            Console.WriteLine("Registation User");
            Console.Write("Enter your name: ");
            UserName = Console.ReadLine();
            Console.Write("Enter your password: ");
            Password = Console.ReadLine();
            Console.Write("Enter your date of birth: ");
            DateOfBirth = Console.ReadLine();
        }

        public void ChangeInfo()
        {
            Console.WriteLine("Change info");
            Console.Write("Enter your name: ");
            UserName = Console.ReadLine();
            Console.Write("Enter your password: ");
            Password = Console.ReadLine();
            Console.Write("Enter your date of birth: ");
            DateOfBirth = Console.ReadLine();
        } 
    }
}
