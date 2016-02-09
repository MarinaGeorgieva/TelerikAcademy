namespace WorkingWithRemoteData.Models
{
    using System;
    using System.Collections.Generic;

    public class Project
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string MainImageUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ShortDate { get; set; }

        public int Likes { get; set; }

        public int Visits { get; set; }

        public int Comments { get; set; }

        public int Flags { get; set; }

        public bool IsHidden { get; set; }

        public string TitleUrl { get; set; }

        public IEnumerable<Collaborator> Collaborators { get; set; }

        public IEnumerable<Tag> Tags { get; set; }
    }
}
