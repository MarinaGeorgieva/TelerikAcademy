namespace WorkingWithRemoteData.Services
{
    using System;
    using System.Threading.Tasks;

    using Models;

    using Newtonsoft.Json;

    using Windows.Web.Http;    
    
    public class BestTAProjectsService
    {
        private const string Url = "http://best.telerikacademy.com/api/projects/popular";

        private readonly HttpClient httpClient;

        public BestTAProjectsService()
        {
            this.httpClient = new HttpClient();
        }

        public async Task<PopularProjects> GetAllProjects()
        {
            var response = await this.httpClient.GetAsync(new Uri(Url));
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<PopularProjects>(content);
            return result;
        }
    }
}
