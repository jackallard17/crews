using Crews.Models;

namespace Crews.Controllers
{
    public class UserController
    {
        public void addUser(User user)
        {
            System.IO.File.WriteAllText("users.txt", user.Name);
        }

        public string[] listUsers()
        {
            return System.IO.File.ReadAllLines("users.txt");
        }
    }
}