// See https://aka.ms/new-console-template for more information
using ReadyApp.Data.Console;
using ReadyApp.Domain;

Console.WriteLine("DDatabase Implemetation");
Database.Init();
System.Console.WriteLine("The Ready App, Welcome");
// 1) Access User Acount
UIControls();


//Database.GetUsers("Before Adding users");
//Database.AddUser(UserData.ListOfUsers(1));
//Database.GetUsers("After Adding users");

//Database.GetUsers("List of users");
//Console.WriteLine("");
//Console.WriteLine("");
//Database.GetCustomers("List of customers");

void UIControls()
{
    var inUse = true;
    
    do
    {
        System.Console.WriteLine("(1) = Login, (2) = Register, (3) = Exit");
        System.Console.WriteLine();
        if (UserData.User != null)
        {
            Console.WriteLine($"User = {UserData.User.Username}");
        }
        switch (System.Console.ReadLine())
        {
            case "1":
                // 1) Get user auth
                var userAuth = UserData.GetUser("Please Login");

                // 2) check if user exist
                if (Database.UserExist(userAuth))
                {
                    UserData.User = Database.GetUser(userAuth);
                } else
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Incurrect Login");
                    System.Console.WriteLine();



                }
                break;
            case "2":
                // 1) Get user auth
                var newUser = UserData.CreateUser();
            break;
            default:
                inUse = false;
                break;
        }
    } while (inUse);
}
void GetUser()
{

}