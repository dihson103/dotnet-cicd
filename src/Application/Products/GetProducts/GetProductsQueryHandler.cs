using Application.Data;
using Application.Shared;
using MediatR;

namespace Application.Products.GetProducts;

internal sealed class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<GetProductResponse>>
{
    private readonly IProductRepository _productRepository;

    public GetProductsQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<GetProductResponse>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetAllAsync();

        if (products == null)
        {
            return null;
        }

        return products.ConvertAll(p => GetProductResponse.Create(p));
    }
}
