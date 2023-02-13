using MediatR;

namespace CQRS;

public class GetProductHandler : IRequestHandler<GetValueQuery, IEnumerable<Product>>
{
    private readonly FakeDataStore _fakeDataStore;
    public GetProductHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

    public async Task<IEnumerable<Product>> Handle(GetValueQuery request, CancellationToken cancellationToken)
    {
        return await _fakeDataStore.GetProducts();
    }
}
