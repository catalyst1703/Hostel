using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelServiseCSharp
{
    internal  static class ApiRequests
    {
        public static string GET_ALL_USERS = "https://localhost:7004/api/Users/get_users";
        public static string GET_USER_BY_ID = $"https://localhost:7004/api/Users/get_user_by_id?id={0}";
        public static string CREATE_USER = "https://localhost:7004/api/Users/create_user";
        public static string EDIT_USER_BY_ID = $"https://localhost:7004/api/Users/edit_user_by_id/{0}";
        public static string DELETE_USER_BY_ID = $"https://localhost:7004/api/Users/delete_user_by_id?id={0}";

    }
}
