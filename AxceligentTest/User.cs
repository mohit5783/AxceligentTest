using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxceligentTest
{
    public class User
    {
        public static List<string> UserList { get; set; } = new List<string>();
        public void Add(string userName)
        {
            UserList.Add(userName);
        }

        public int GetUsersCount()
        {
            return UserList.Count;
        }
    }
}
