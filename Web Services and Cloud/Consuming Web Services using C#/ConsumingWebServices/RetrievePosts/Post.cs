namespace RetrievePosts
{
    public class Post
    {
        public int UserId { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Id: {0} \nTitle: {1} \nBody: {2}\n", 
                this.Id, 
                this.Title, 
                this.Body);
        }
    }
}
