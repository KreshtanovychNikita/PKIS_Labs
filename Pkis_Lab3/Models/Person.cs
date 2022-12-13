using MongoDB.Bson;
namespace Lab3.Models;

public sealed class Person: ModelBase
{
        public int Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string? Middlename { get; set; } = null!;
}
