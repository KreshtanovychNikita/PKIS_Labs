namespace Lab6.Models;

public sealed class Person : ModelBase
{
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string? Middlename { get; set; } = null!;
}

    public string Description => $"{FirstName}, {LastName}";

