using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Models;
using Newtonsoft.Json;
//using System.Web.Script 

namespace ConsumeRestApi
{
    class Program
    {
        static async Task<string> get()
        {
            HttpClient client = new HttpClient();
           // client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/users");
            var response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");


            var result = response.Content.ReadAsStringAsync().Result;
            //var result = JsonConvert.DeserializeObject

            return result;
        }

        internal class Users
        {
            public List<Models.User> data;// { get; set; }
        }

        static void Main(string[] args)
        {
            var data = get();
            Console.WriteLine(data.Result);
            
            Console.WriteLine("===========================================================================");
            Console.WriteLine("===========================================================================");
            Console.WriteLine("===========================================================================");

            List<Models.User> users = JsonConvert.DeserializeObject<List<Models.User>>(data.Result);



            //           Users users = new Users();

            foreach (User user in users)
            {
                //Models.User user = new Models.User();
                //user.id = item.id;
                //users.data.Add(user);
                Console.WriteLine(user.ToString()+ "\n");
            }

            //foreach ( Models.User user in users.data)
            //{
            //    Console.WriteLine(user.id);
            //}

            Console.Read();
        }
    }
}
