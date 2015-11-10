namespace RetrievePosts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;

    using Newtonsoft.Json;

    public class Startup
    {
        private const string Url = @"http://jsonplaceholder.typicode.com/";

        public static void Main()
        {
            Console.Write("Enter query string (by default set to 'dolorem'): ");
            string queryString = Console.ReadLine();
            if (string.IsNullOrEmpty(queryString))
            {
                queryString = "dolorem";
            }

            Console.Write("Enter count of posts to retrieve (by default set to 3): ");
            int count;
            bool isValidNumber = int.TryParse(Console.ReadLine(), out count);
            if (!isValidNumber)
            {
                count = 3;
            }

            Console.WriteLine("Retrieving posts...");
            GetPostsByQueryString(queryString, count);

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        private static async void GetPostsByQueryString(string query, int count)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(Url);
                var response = await httpClient.GetAsync("posts");

                var content = response.Content.ReadAsStringAsync().Result;
                var posts = JsonConvert.DeserializeObject<List<Post>>(content);
                var filteredPosts = posts.Where(p => p.Title.Contains(query)).Take(count);

                Console.WriteLine("\nPosts: \n");
                foreach (var post in filteredPosts)
                {
                    Console.WriteLine(post);
                }
            }            
        }
    }
}
