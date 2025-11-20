using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Services
{
    public static class UserService
    {
        public static string Role { get; private set; }

        public static void SetUserRole(string role)
        {
            Role = role;
        }
    }
}
