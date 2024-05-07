using MediatR;

namespace Application.Products.Update;

public record UpdateProductCommand(
    Guid id, 
    string productName, 
    decimal productPrice, 
    int productQuanity) : IRequest;
