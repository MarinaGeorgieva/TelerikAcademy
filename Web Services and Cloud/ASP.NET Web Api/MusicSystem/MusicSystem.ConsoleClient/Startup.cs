namespace MusicSystem.ConsoleClient
{    
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading;

    using Newtonsoft.Json.Linq;

    public class Startup
    {
        public static void Main()
        {
            Thread.Sleep(3000);

            var connection = new Uri("http://localhost:53969/");

            PrintJsonArtists(connection, "api/artists");
            PrintXmlSongs(connection, "api/songs");
            PostAlbum(connection, "api/albums");

            Console.ReadLine();
        }

        private static async void PrintJsonArtists(Uri connection, string requestPath)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = connection;
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await httpClient.GetAsync(requestPath);
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(Environment.NewLine + "Artists: " + content);
            }
        }

        private static async void PrintXmlSongs(Uri connection, string requestPath)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = connection;
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));

                var response = await httpClient.GetAsync(requestPath);
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(Environment.NewLine + "Songs: " + content);
            }
        }

        private static async void PostAlbum(Uri connection, string requestPath)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = connection;

                var json = JObject.Parse("{\"Title\": \"Recovery\",\"Year\": 2010,\"Producer\": \"Dr.Dre\"}");

                var response = await httpClient.PostAsync(
                    requestPath,
                    new StringContent(
                        json.ToString(),
                        Encoding.UTF8,
                        "application/json"));

                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(Environment.NewLine + "Added Album: " + content);
            }
        }
    }
}
