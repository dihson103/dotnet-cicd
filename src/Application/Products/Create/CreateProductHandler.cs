using Application.Data;
using Domain.Entities;
using MediatR;

namespace Application.Products.Create;

internal sealed class CreateProductHandler : IRequestHandler<CreateProductCommand>
{
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = Product.Create(
            Guid.NewGuid(), 
            request.ProductName, 
            request.ProductPrice, 
            request.ProductQuanity);

        _productRepository.AddProduct(product);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
