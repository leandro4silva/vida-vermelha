using MediatR;

namespace VidaVermelha.Application.Handlers.CreateDoador;

public class CreateDoadorHandler : IRequestHandler<CreateDoadorCommand, CreateDoadorResult>
{
    public Task<CreateDoadorResult> Handle(CreateDoadorCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
