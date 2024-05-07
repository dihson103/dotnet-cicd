namespace Domain.Abstractions.Entities;

public interface IDateTracking
{
    DateTime CreatedDate { get; set; }
    DateTime UpdatedDate { get; set; }
}
