using AppEntities.interfaces;

namespace AppEntities.Entities
{
    public record Product : IEntityAggreateRoot
    {
        public int Id { get; init; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
