
namespace SistemasCP.Models
{
    public class CriminalCodes
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public DateTime Penalty { get; set; }
        public int PrisionTime { get; set; }
        public ICollection<status> StatusId { get; set; } = new List<status>();
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        public User? User { get; set; }

        public CriminalCodes() 
        {
        }

        public CriminalCodes(int id, string? name, string? description, DateTime penalty, int prisionTime, DateTime createDate, DateTime updateDate, int createUserId, int updateUserId, User? user)
        {
            Id = id;
            this.name = name;
            this.description = description;
            Penalty = penalty;
            PrisionTime = prisionTime;
            CreateDate = createDate;
            UpdateDate = updateDate;
            CreateUserId = createUserId;
            UpdateUserId = updateUserId;
            User = user;
        }
    }
}
