using ReadyApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Data.Console
{
    public static class UserData
    {
        public static User? User { get; set; } = null;

        public static List<User> CreateUser()
        {
            var listOfUsers = new List<User>();
            var complete = false;
            
            do
            {
                System.Console.WriteLine("(1) = Register User, (2) = Complete/Exit");
                switch (System.Console.ReadLine())
                {
                    case "1":
                        listOfUsers.Add(InputUserData());
                        break;
                    case "2":
                        complete = true;
                        break;
                    default:
                        System.Console.WriteLine("Not a option, TRY AGAIN");
                        break;
                }
            } while (!complete);
            return listOfUsers;
                
            
        }
        public static User GetUser(string message)
        {
            System.Console.WriteLine(message);
            System.Console.WriteLine("");
            var username = Input("Username");
            var email = Input("Email");
            var password = Input("Password");


            return new User()
            {
                Username = username,
                Email = email,
                Password = password
            };
        }
        /// <summary>
        /// In memery collection of users
        /// </summary>
        /// <param name="numberOfUsers"></param>
        /// <returns>number if users requested max of 10 users</returns>
        public static List<User> ListOfUsers(int numberOfUsers = 10, bool inputData = false)
        {
            var usersRequested = new List<User>();
            
            if (numberOfUsers >= 11 || numberOfUsers <= 0)
            {
                for (int i = 0; i < GeneratedUserData().Count(); i++)
                {
                    usersRequested.Add(GeneratedUserData()[i]);
                }
            }
            else
            {
                for (int i = 0; i < numberOfUsers; i++)
                {
                    usersRequested.Add(GeneratedUserData()[i]);
                }
            }

            return usersRequested;
        }

        private static List<User> GeneratedUserData()
        {
            return new List<User>()
            {
                new User()
                {
                    Username = "$solotech123",
                    Email = "solo@gmail.com",
                    Password = "s12340",
                    FullName = "solotech"
                },
                new User()
                {
                    Username = "$Tim643",
                    Email = "timcook@gmail.com",
                    Password = "Timpassword",
                    FullName = "solotech"
                },
                new User()
                {
                    Username = "$mike89",
                    Email = "mike@yahoo.com",
                    Password = "likemike",
                    FullName = "solotech"
                },
                new User()
                {
                    Username = "$Tom",
                    Email = "tom@tomllc.com",
                    Password = "trust",
                    FullName = "solotech"
                },
                new User()
                {
                    Username = "$jenna",
                    Email = "jenna@microsoft.com",
                    Password = "ilovecats",
                    FullName = "solotech"
                },
                new User()
                {
                    Username = "$pat",
                    Email = "patcook@gmail.com",
                    Password = "pattycake",
                    FullName = "solotech"
                },
                new User()
                {
                    Username = "$trisha43",
                    Email = "ttbaby@gmail.com",
                    Password = "tete2015",
                    FullName = "solotech"
                },
                new User()
                {
                    Username = "$shawn21",
                    Email = "tooensure@gmail.com",
                    Password = "imagenuis",
                    FullName = "solotech"
                },
                new User()
                {
                    Username = "$doe21",
                    Email = "techsavvy@gmail.com",
                    Password = "techtech",
                    FullName = "solotech"
                },
                new User()
                {
                    Username = "$jay",
                    Email = "ceo@jayjays.com",
                    Password = "jay321",
                    FullName = "solotech"
                },

            };
        }
        private static User InputUserData()
        {
            System.Console.WriteLine("Create User Account");
            System.Console.WriteLine("");
            var username = Input("Username");
            var email = Input("Email");
            var password = Input("Password");


            return new User()
            {
                Username = username,
                Email = email,
                Password = password
            };
        }

        private static string Input(string message)
        {
            System.Console.Write($"Enter {message}: ");
            var input = System.Console.ReadLine();
            return input;
        }
    }
}
