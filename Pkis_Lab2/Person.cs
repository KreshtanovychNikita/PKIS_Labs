using System.ComponentModel.DataAnnotations;

namespace Pkis_lab2
{
    internal class Person
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string? Middlename { get; set; } = null!;
    }
}
