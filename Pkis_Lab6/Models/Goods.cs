namespace Lab6.Models;

public sealed class Goods : ModelBase
{
     public string GoodsName {get; set;}
        public Guid Id { get; set; }
        public Guid CompanyId {get; set;}
        public string CalculateV {get; set;}
        public int QuantityOfGoods {get; set;}
        public string SaleTime {get; set;}
        public int Discount {get; set;}
        public int Price {get; set;}
        public string Description {get; set;}

    public string Description => $"{GoodsName}, {Price}";
}
