namespace Api.Controllers.User.Requests
{
    public class UserRegisterRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Avatar { get; set; }
    }
}
