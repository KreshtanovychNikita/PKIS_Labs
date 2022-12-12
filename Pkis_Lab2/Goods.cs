using System.ComponentModel.DataAnnotations;

namespace Pkis_lab2
{
    internal class Goods
    {
        [Key]
        public string GoodsName {get; set;}
        public int Id { get; set; }
        public int CompanyId {get; set;}
        public string CalculateV {get; set;}
        public int QuantityOfGoods {get; set;}
        public string SaleTime {get; set;}
        public int Discount {get; set;}
        public int Price {get; set;}
        public string Description {get; set;}
    }
}
