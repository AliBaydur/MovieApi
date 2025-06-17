using MediatR;
using MovieApi.Application.Features.MediatorDesingPattern.Commands.TagCommands;
using MovieApi.Persistence.Context;
using MovieAPI.Domain.Entities;

namespace MovieApi.Application.Features.MediatorDesingPattern.Handlers.TagHandlers
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand>
    {
        private readonly MovieContext _context;

        public CreateTagCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
           await _context.Tags.AddAsync(new Tag
            {
                Title = request.Title,
            });
            await _context.SaveChangesAsync();
        }
    }
}
