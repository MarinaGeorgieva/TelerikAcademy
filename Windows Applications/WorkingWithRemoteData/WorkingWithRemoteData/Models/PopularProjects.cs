namespace WorkingWithRemoteData.Models
{    
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class PopularProjects
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("data")]
        public IEnumerable<Project> Projects { get; set; }
    }
}
