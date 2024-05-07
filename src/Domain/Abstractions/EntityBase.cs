using Domain.Abstractions.Entities;

namespace Domain.Abstractions;

public abstract class EntityBase<T> : IEntityBase<T>
{
    public T Id {  get; set; }
}
