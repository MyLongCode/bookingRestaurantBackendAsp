using Dal.Role.Models;

namespace Dal.User.Models
{
    public class UserDal 
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }    
        public string FullName { get; set; }
        public DateTime BirthDate{ get; set; }
        public string PhoneNumber { get; set; }
        public string Avatar { get; set; }
        public int RoleId { get; set; }
        public RoleDal Role { get; set; }
    }
}
