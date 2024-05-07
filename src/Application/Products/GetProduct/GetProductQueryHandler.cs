using Application.Data;
using Application.Shared;
using MediatR;


internal sealed class GetProductQueryHandler : IRequestHandler<GetProductQuery, GetProductResponse>
{
    private readonly IProductRepository _productRepository;

    public GetProductQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<GetProductResponse> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.FindByIdAsync(request.productId);

        if (product is null)
        {
            return null;
        }

        return GetProductResponse.Create(product);
    }
}
