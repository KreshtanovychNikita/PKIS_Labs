using Lab3.Models;
using Lab3.Repositories;
using MongoDB.Driver;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IMongoClient, MongoClient>(sp => new MongoClient(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSingleton(s =>
{
    var mongoClient = s.GetRequiredService<IMongoClient>();
    return mongoClient.GetDatabase(builder.Configuration.GetSection("GoodsCompnanyDatabase")["Name"]);
});
builder.Services.AddSingleton(typeof(IRepository<>), typeof(GenericRepository<>));

var app = builder.Build();

app.MapGet("/", async (HttpContext context) =>
{
    var itemCompanyRepository = app.Services.GetRequiredService<IRepository<itemsCompanys>>();
    var itemsCompany = (await itemCompanyRepository.GetAllAsync()).GroupBy(b => new { b.Person.FirstName, b.Person.LastName });

    context.Response.Headers.ContentType = new Microsoft.Extensions.Primitives.StringValues("text/html; charset=UTF-8");

    var itemsCompanyString = new StringBuilder();
    itemsCompanyString.AppendLine("<img src=\"/img/logo_svg.svg\" alt=\"logo\" width='50' height='50'/>");
    foreach (var itemsCompanys in itemsCompany)
    {
        itemsCompanyString.AppendLine("<div>");
        itemsCompanyString.AppendLine($"<h2>{itemsCompanys.Key.FirstName} {itemsCompanys.Key.LastName}</h2>");
        itemsCompanyString.AppendLine($"<p>Item avaible :{itemsCompanys.Count()} goods </p>");
        itemsCompanyString.AppendLine("<ul>");
        foreach (var goodsInfo in itemsCompanys)
        {
            itemsCompanyString.AppendLine($"<li>{goodsInfo.Goods.GoodsName}</li>");
        }
        itemsCompanyString.AppendLine("</ul>");
        itemsCompanyString.AppendLine("</div>");
    }

    await context.Response.WriteAsync(text: "<html><body>" +
        "<h1>Goods Company </h1>" +
        itemsCompanyString.ToString() +
        "<body></html>");
});

app.UseStaticFiles();

app.Run();
