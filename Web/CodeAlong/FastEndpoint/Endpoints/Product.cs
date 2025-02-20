using FastEndpoints.DTO;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;


public class ProductDB
{
    public static List<ProductRequest> _products = new List<ProductRequest>() {
        new ProductRequest{ Id=1, Name="Cola", Category="Drinks", Stock=10},
        new ProductRequest{ Id=2, Name="Candy", Category="Snacks", Stock=10},
        new ProductRequest{ Id=3, Name="Chips", Category="Snacks", Stock=10},
        new ProductRequest{ Id=4, Name="Fanta", Category="Drinks", Stock=10},
    };
}



public class GetAllProductsEndpoint : EndpointWithoutRequest<List<ProductResponse>>
{
    public override void Configure()
    {
        Get("/products");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var products = ProductDB._products.Select(p => new ProductResponse{
            Id = p.Id,
            Name = p.Name,
            InStock = p.Stock > 0
        }).ToList();

        await SendAsync(products, cancellation: ct);
    }
}


// Create product

public class CreateProductEndpoint : Endpoint<ProductRequest, ProductResponse>
{
    public override void Configure()
    {
        Post("/products");
        AllowAnonymous();
    }

    public override async Task HandleAsync(ProductRequest req, CancellationToken ct)
    {
        ProductDB._products.Add(req);
        var response = new ProductResponse
        {
            Id = req.Id,
            Name = req.Name,
            InStock = req.Stock > 0
        };

        await SendAsync(response, cancellation: ct);
    }
}