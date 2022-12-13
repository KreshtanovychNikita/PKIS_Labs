using MongoDB.Bson;

namespace Lab3.Models;
{
    internal class Company
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; } = null!; 
        public string PhoneCompanyNumber { get; set; }
        public string AddresCompany { get; set; }

       // public Goods Goods { get; set; } = null!;
    }
}
