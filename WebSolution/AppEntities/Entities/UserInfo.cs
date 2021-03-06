using AppEntities.interfaces;

namespace AppEntities.Entities
{
    public record UserInfo : IEntityAggreateRoot
    {
        public int Id { get; init; }
        public string? UserKey { get; init; }
        public string? Name { get; init; }
        public string? Email { get; init; }
        public bool IsActivate { get; set; }
        public DateTime CreateDate { get; init; }
    }
}
