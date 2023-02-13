using MediatR;

namespace CQRS;

public class GetProductByIdHandler : IRequestHandler<GetProductById, Product>
{
    private readonly FakeDataStore _fakeDataStore;
    public GetProductByIdHandler(FakeDataStore fakeDataStore) =>
        _fakeDataStore = fakeDataStore;

    public async Task<Product> Handle(GetProductById request, CancellationToken cancellationToken)
    {
        return await _fakeDataStore.GetProductsById(request.Id);
    }
}
