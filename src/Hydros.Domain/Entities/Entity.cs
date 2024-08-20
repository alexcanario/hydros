namespace Hydros.Domain.Entities;

public abstract class Entity(Guid id)
{
    public Guid Id { get; private set; } = id;
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}