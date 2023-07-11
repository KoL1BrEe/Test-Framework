using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestLearning.ApiManagers.UsersManager
{
    public class UsersRoutes
    {
        public static string USERS = "users";
        public static string USER(int id) => $"users/{id}";
        public static string REGISTER = "register";
    }
}
