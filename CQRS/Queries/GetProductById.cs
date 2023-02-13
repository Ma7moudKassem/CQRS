using MediatR;

namespace CQRS;

public record GetProductById(int Id) : IRequest<Product>;
