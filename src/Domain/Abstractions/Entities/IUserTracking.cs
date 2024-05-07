namespace Domain.Abstractions.Entities;

public interface IUserTracking
{
    String CreatedBy { get; set; }
    String UpdatedBy { get; set; }
}
