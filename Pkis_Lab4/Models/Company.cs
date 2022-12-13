namespace Lab4.Models;

public sealed class Company : ModelBase
{
    public Guid Id { get; set; }
        public string CompanyName { get; set; } = null!; 
        public string PhoneCompanyNumber { get; set; }
        public string AddresCompany { get; set; }

    public string Description => $"{Country}, {City}, {Street},";
}
