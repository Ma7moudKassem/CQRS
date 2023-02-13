namespace CQRS;

public class FakeDataStore
{
    private static List<Product> _products;

    public FakeDataStore()
    {
        _products = new()
        {
            new Product{Id = 1, Name = "Game" },
            new Product{Id = 2, Name = "Movie" },
            new Product{Id = 3, Name = "Song" },
        };
    }

    public async Task AddProduct(Product product)
    {
        _products.Add(product);
        await Task.CompletedTask;
    }

    public async Task<List<Product>> GetProducts() => await Task.FromResult(_products);
    public async Task<Product> GetProductsById(int id) => await Task.FromResult(_products.FirstOrDefault(e => e.Id == id));
}
