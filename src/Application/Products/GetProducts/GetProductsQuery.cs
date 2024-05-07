using Application.Shared;
using MediatR;


public record GetProductsQuery() : IRequest<List<GetProductResponse>>;
