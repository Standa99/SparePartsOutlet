
namespace SparePartsOutletApp.Models.Entities
{
    public class User
    {
        public int Id { get; set; } 
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string PasswordHashed { get; set; }
        public string RoleName { get; set; }
    }
}
