namespace ProjectKard.Domain
{
    public class Admin : BaseDomainModel
    {
        public string? Name
        {
            get; set;
        }
      
        public int Contact
        {
            get; set;
        }
        public string? UserId { get; set; }
        public Boolean Approval { get; set; }
    } 
}
