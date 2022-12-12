using System.Data.SqlClient;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using (SqlConnection connection = new SqlConnection("Server=localhost;Database=CompanyGoods;Trusted_Connection=True;"))
        {
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT Person.Id,Person.Firstname,Person.Middlename,Person.Lastname,Company.GoodsName,Company.CompanyName,Company.PhoneCompanyNumberCompany,
            Company.GoodsNameCompany,Goods.GoodsName,Goods.CompanyId as CompanyId,Goods.CalculateV,Goods.QuantityOfGoods,Goods.SaleTime,Goods.Discount,Goods.Price,Goods.Description";

            SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();

            Console.WriteLine("\tFirstName\tMiddleName\tLastName\tGoodsName\tCompanyName\tPhoneCompanyNumber\tGoodsNameCompany\tCalculateV\tQuantityOfGoods\tSaleTime\tDiscount\tPrice\tDescription");

            while (await reader.ReadAsync())
            {
                Console.WriteLine($"" +
                    $"\t{reader["Firstname"]}" +
                    $"\t{reader["Middlename"]}" +
                    $"\t{reader["Lastname"]}" +
                    $"\t{reader["GoodsName"]}" +
                    $"\t{reader["CompanyName"]}" +
                    $"\t{reader["PhoneCompanyNumber"]}" +
                    $"\t{reader["GoodsNameCompany"]}" +
                    $"\t{reader["CalculateV"]}" +
                    $"\t{reader["QuantityOfGoods"]}" +
                    $"\t{reader["SaleTime"]}" +
                    $"\t{reader["Discount"]}" +
                    $"\t{reader["Price"]}" +
                    $"\t{reader["Description"]}");
            }

            connection.Close();
        }



    }
}