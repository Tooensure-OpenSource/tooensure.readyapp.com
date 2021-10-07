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
        /// <summary>
        /// In memery collection of users
        /// </summary>
        /// <param name="numberOfUsers"></param>
        /// <returns>number if users requested max of 10 users</returns>
        public static List<User> ListOfUsers(int numberOfUsers = 10)
        {
            var usersRequested = new List<User>();
            var users = new List<User>()
            {
                new User()
                {
                    Username = "$solotech123",
                    Email = "solo@gmail.com",
                    Password = "s12340"
                },
                new User()
                {
                    Username = "$Tim643",
                    Email = "timcook@gmail.com",
                    Password = "Timpassword"
                },
                new User()
                {
                    Username = "$mike89",
                    Email = "mike@yahoo.com",
                    Password = "likemike"
                },
                new User()
                {
                    Username = "$Tom",
                    Email = "tom@tomllc.com",
                    Password = "trust"
                },
                new User()
                {
                    Username = "$jenna",
                    Email = "jenna@microsoft.com",
                    Password = "ilovecats"
                },
                new User()
                {
                    Username = "$pat",
                    Email = "patcook@gmail.com",
                    Password = "pattycake"
                },
                new User()
                {
                    Username = "$trisha43",
                    Email = "ttbaby@gmail.com",
                    Password = "tete2015"
                },
                new User()
                {
                    Username = "$shawn21",
                    Email = "tooensure@gmail.com",
                    Password = "imagenuis"
                },
                new User()
                {
                    Username = "$doe21",
                    Email = "techsavvy@gmail.com",
                    Password = "techtech"
                },
                new User()
                {
                    Username = "$jay",
                    Email = "ceo@jayjays.com",
                    Password = "jay321"
                },

            };


            if (numberOfUsers >= 11 || numberOfUsers <= 0)
            {
                for (int i = 0; i < users.Count(); i++)
                {
                    //users[i].SetId(i);
                    usersRequested.Add(users[i]);
                }
            }
            else
            {
                for (int i = 0; i < numberOfUsers; i++)
                {
                    //users[i].SetId(i);
                    usersRequested.Add(users[i]);
                }
            }

            return usersRequested;
        }
    }
}
