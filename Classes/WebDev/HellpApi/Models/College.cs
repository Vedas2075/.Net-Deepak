namespace HellpApi.Models
{
    public class College
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public DateTime EstablishedDate { get; set; }
        public short Rank { get; set; }
    }
}
