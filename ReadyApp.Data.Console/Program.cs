// See https://aka.ms/new-console-template for more information
using ReadyApp.Data.Console;
using ReadyApp.Domain;
using ReadyApp.Domain.Entity;

Console.WriteLine("Hello, World!");

var user1 = new User()
{
    Username = "$Tooensure",
    Email = "iosjd@gmail.com",
    Password = "2132"
};
var business1 = new Business();

Database.AddUser(user1);
Database.AddBusiness(business1);