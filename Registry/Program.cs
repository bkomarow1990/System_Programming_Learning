using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registry_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string correct_login = "admin";
            string correct_password = "12345";
            //RegistryKey localMachine = Registry.CurrentUser;
            RegistryKey learningRegistryCatalog = Registry.CurrentUser.CreateSubKey("Learning");
            if (learningRegistryCatalog.GetValue("login") == null && learningRegistryCatalog.GetValue("password") == null) {
                string login = Console.ReadLine();
                string password = Console.ReadLine();
                learningRegistryCatalog.SetValue("login", login);
                learningRegistryCatalog.SetValue("password", password);
            }
            else
            {
                if (learningRegistryCatalog.GetValue("login") as string == correct_login && learningRegistryCatalog.GetValue("password") as string == correct_password) {
                    Console.WriteLine("Correct login and password");
                }
                else
                {

                    Console.WriteLine("Incorrect login and password");
                }
            }
            Console.WriteLine("End of programm");

                
           

        }
    }
}
