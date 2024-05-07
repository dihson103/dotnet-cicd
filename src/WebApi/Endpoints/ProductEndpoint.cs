using Application.Products.Create;
using Application.Products.Delete;
using Application.Products.Update;
using Application.Shared;
using Carter;
using MediatR;

namespace WebApi.Endpoints;

public class ProductEndpoint : CarterModule
{
    public ProductEndpoint() : base("/api/products")
    {
    }
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/", async (ISender sender) =>
        {
            List<GetProductResponse> result = await sender.Send(new GetProductsQuery());

            return Results.Ok(result);
        }).WithDisplayName("GetAllProducts");

        app.MapGet("/{id:guid}", async (Guid id, ISender sender) =>
        {
            GetProductResponse result = await sender.Send(new GetProductQuery(id));

            return Results.Ok(result);
        }).WithDisplayName("GetProductByID");

        app.MapPost("", async (CreateProductCommand command, ISender sender) =>
        {
            await sender.Send(command);

            return Results.Ok("Create success");    
        }).WithDisplayName("CreateProduct");

        app.MapPut("", async (UpdateProductCommand command, ISender sender) =>
        {
            await sender.Send(command);

            return Results.Ok("Update success");
        }).WithDisplayName("Update product");

        app.MapDelete("/{id:guid}", async (Guid id, ISender sender) =>
        {
            await sender.Send(new DeleteProductCommand(id));

            return Results.Ok("Delete success");
        }).WithDisplayName("Delete product");
    }
}
