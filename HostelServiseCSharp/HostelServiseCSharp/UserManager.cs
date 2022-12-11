using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HostelServiseCSharp
{
    public  static class UserManager
    {
        public static async Task<User[]> GetAllUsers()
        {
            try
            {
                string urlRequest = ApiRequests.GET_ALL_USERS;
                WebRequest request = WebRequest.Create(urlRequest);

                using WebResponse webResponse = await request.GetResponseAsync();
                using Stream webStream = webResponse.GetResponseStream();

                using TextReader reader = new StreamReader(webStream);
                string data = reader.ReadToEnd();

                return JsonConvert.DeserializeObject<User[]>(data);
            }
            catch
            {
                return null;
            }
            
        }

        public static async Task<User> GetUser(int id)
        {
            try
            {
                string urlRequest = string.Format(ApiRequests.GET_USER_BY_ID, id);
                WebRequest request = WebRequest.Create(urlRequest);

                using WebResponse webResponse = await request.GetResponseAsync();
                using Stream webStream = webResponse.GetResponseStream();

                using TextReader reader = new StreamReader(webStream);
                string data = reader.ReadToEnd();

                return JsonConvert.DeserializeObject<User>(data);
            }
            catch
            {
                return null;
            }
        }
        public static async Task CreateUser(User user)
        {
            try
            {

                string json = JsonConvert.SerializeObject(user);
                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                string url = ApiRequests.CREATE_USER;
                using HttpClient client = new HttpClient();

                await client.PostAsync(url, data);
            }
            catch
            {
                return;
            }
        }
        public static async Task EditUser(int id, User user)
        {
            try
            {
                user.Id = id;
                string json = JsonConvert.SerializeObject(user);
                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                using HttpClient client = new HttpClient();

                await client.PutAsync(string.Format(ApiRequests.EDIT_USER_BY_ID, id), data);
            }
            catch
            {
                return;
            }
        }
    }
}
