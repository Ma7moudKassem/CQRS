using MediatR;

namespace CQRS;

public record GetValueQuery() : IRequest<IEnumerable<Product>>;
