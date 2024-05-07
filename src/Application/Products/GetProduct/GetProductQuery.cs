using Application.Shared;
using MediatR;

public record GetProductQuery(Guid productId) : IRequest<GetProductResponse>;
