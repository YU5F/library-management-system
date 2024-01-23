using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    public class AuthenticatedUser
    {
        public static User LoggedInUser { get; set; } = new User();

        public static void SignOut()
        {
            LoggedInUser.SetDefaultValues();
        }
    }
}
