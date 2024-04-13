using UserAccountBusiness;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Username: ");
        string UserName = Console.ReadLine();

        Console.WriteLine("Enter Password: ");
        string password = Console.ReadLine();

        UserService userService = new UserService();
        bool result = userService.VerifyUser(UserName, password);

        if (result)
        {
            Console.WriteLine("Welcome to UserUI");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}