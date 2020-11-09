using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using AndriuhaAssignment.Models;

namespace AndriuhaAssignment.Data
{
    public class InMemoryUserService : IUserService
    {
        private HttpClient client;
        
        public InMemoryUserService()
        {
            client = new HttpClient();
        }
        
        public async Task<User> GetUserAsync(string? username, string? password)
        {
            string uri = "http://localhost:6969/users/get?";
            
            if (username != null)
            {
                uri += $"&username={username}";
            }

            if (username != null)
            {
                uri += $"&password={password}";
            }

            Console.Out.WriteLine(uri);
            HttpResponseMessage response = await client.GetAsync("http://localhost:6969/users/get");
            Console.Out.WriteLine(response);
            // string message = await client.GetStringAsync(uri);
            string message = await client.GetStringAsync(uri);
            User result = JsonSerializer.Deserialize<User>(message);
            Console.Out.WriteLine("opa " + result.UserName);
            return result;
        }
    }
}