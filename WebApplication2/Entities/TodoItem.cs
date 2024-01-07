namespace WebApplication2.Entities
{
    public class TodoItem : BaseEntity
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? S { get; set; }
        public bool IsComplete { get; set; }
        public bool IsDone { get; set; }
    }
}
