using MediatR;
using MovieApi.Application.Features.MediatorDesingPattern.Queries.TagQueries;
using MovieApi.Application.Features.MediatorDesingPattern.Results.TagResult;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesingPattern.Handlers.TagHandlers
{
    public class GetTagByQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
    {
        private readonly MovieContext _context;

        public GetTagByQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.FindAsync(request.TagId);
            return new GetTagByIdQueryResult
            {                
                Title = request.Title
            };
        }
    }
}
