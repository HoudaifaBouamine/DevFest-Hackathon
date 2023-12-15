namespace DevFest.Api.Entities
{
    public class User
    {

        public Guid User_Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Identity { get; set; } = "";
        public string HashedPassword { get; set; } = "";


        public static List<UserReadDto> UsersToDtos(List<User> users)
        {
            return (from u in users select new UserReadDto(u)).ToList();
        }

        public User()
        {
            
        }
        public User(UserCreateDto userCreateDto)
        {
            User_Id = Guid.NewGuid();
            FirstName = userCreateDto.FirstName;
            LastName = userCreateDto.LastName;
            Email = userCreateDto.Email;
            Identity = userCreateDto.Identity;
            HashedPassword = userCreateDto.Password; // Must be hashed in full functional app
        }
    }

    public class UserLoginDto
    {

        public string Email { get; set; } = "";
        public string Password { get; set; } = "";

    }

    public class UserReadDto
    {

        public Guid User_Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Identity { get; set; } = "";

        public UserReadDto(User user)
        {
            User_Id = user.User_Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email; 
            Identity = user.Identity;
        }
    }

    public class UserCreateDto
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Identity { get; set; } = "";
        public string Password { get; set; } = "";
    }

}
