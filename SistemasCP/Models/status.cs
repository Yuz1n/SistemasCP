namespace SistemasCP.Models
{
    public class status
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public CriminalCodes? CriminalCodes { get; set; }

        public status()
        { 
        }

        public status(int id, string? name, CriminalCodes criminalCodes)
        {
            Id = id;
            Name = name;
            CriminalCodes = criminalCodes;
        }
    }
}
