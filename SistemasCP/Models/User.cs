namespace SistemasCP.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? password { get; set; }
        public ICollection<CriminalCodes> CriminalCodes { get; set; } = new List<CriminalCodes>();

        public User()
        {
        }

        public User(int id, string? userName, string? password)
        {
            Id = id;
            UserName = userName;
            this.password = password;
        }
    }
}
