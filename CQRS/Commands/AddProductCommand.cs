using MediatR;

namespace CQRS;

public record AddProductCommand(Product Product) : IRequest;