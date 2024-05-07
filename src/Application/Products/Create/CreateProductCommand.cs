using MediatR;

namespace Application.Products.Create;

public record CreateProductCommand(
    string ProductName, 
    decimal ProductPrice, 
    int ProductQuanity) : IRequest;
