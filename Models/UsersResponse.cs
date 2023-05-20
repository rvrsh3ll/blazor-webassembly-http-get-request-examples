namespace BlazorApp.Models
{
    public class UsersResponse
    {
        public string Total { get; set; }
        public User[] Data { get; set; }
    }
}