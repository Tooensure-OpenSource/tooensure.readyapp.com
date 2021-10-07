// See https://aka.ms/new-console-template for more information
using ReadyApp.Data.Console;
using ReadyApp.Domain;

Console.WriteLine("DDatabase Implemetation");
Database.Init();

Database.GetUsers("Before Adding users");
//Database.AddUser(UserData.ListOfUsers());
Database.GetUsers("After Adding users");