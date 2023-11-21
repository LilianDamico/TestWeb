namespace TestWeb.Models
{
    public class LoginPage
    {
        public int Id { get; set; }
        public string LoginName { get; set; } = string.Empty;
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
