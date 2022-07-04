using AppEntities.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEntities.Entities
{
    public record UserInfo : IEntityAggrateRoot
    {
        public int Id { get; init; }
        public string? UserKey { get; init; }
        public string? Name { get; init; }
        public string? Email { get; init; }
        public UserProfile? UserProfile { get; set; }
        public bool IsActivate { get; set; }
        public DateTime CreateDate { get; init; }
    }

    public record UserProfile : IEntityAggrateRoot
    {
        public int Id { get; init; }
        public string? FilePath { get; init; }
        public DateTime CreateDate { get; init; }
    }

    public record Store
    {
        public int Id { get; init; }
        public string? Name { get; init; }
        public ICollection<Product>? Products { get; set; }
        public bool IsUse { get; set; }
        public DateTime CreateDate { get; init; }

    }

    public record Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
    }
}
