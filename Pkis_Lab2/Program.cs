using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pkis_lab2;

internal class Program
{
    private static void Main(string[] args)
    {
        var conf = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json").Build();

        var optionBuilder = new DbContextOptionsBuilder<DbConnection>();
        var libraryGoodsDB = new DbConnection(optionBuilder.UseSqlServer(conf.GetConnectionString("CompanyGoods")).Options);

        var res = companyDB.Company.Include(x => x.Person).Include(x=>x.Company.Goods).Include(x=>x.Person).Include(x=>x.Goods).ToList();
        foreach (var item in res)
        {
            Console.WriteLine($"" +
                   $"\t{item.Person.Person.Firstname}" +
                   $"\t{item.Person.Person.Middlename}" +
                   $"\t{item.Person.Person.Lastname}" +
                   $"\t{item.Company.CompanyName}" +
                   $"\t{item.Company.PhoneCompanyNumber}" +
                   $"\t{item.Company.AddresCompany}" +
                   $"\t{item.Company.Goods.GoodsName}" +
                   $"\t{item.SaleTime}" +
                   $"\t{item.Discount}" +
                   $"\t{item.Goods.Description}");
        }
    }


    
}
