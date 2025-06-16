using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.MediatorDesingPattern.Queries.TagQueries;
using MovieApi.Application.Features.MediatorDesingPattern.Results.TagResult;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesingPattern.Handlers.TagHandlers
{
    public class GetTagQueryHandler : IRequestHandler<GetTagQuery, List<GetTagQueryResult>>
    {
        private readonly MovieContext _context;

        public GetTagQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetTagQueryResult>> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.ToListAsync();
            return values.Select(x => new GetTagQueryResult
            {
              TagId = x.TagId,
              Title = x.Title,
            }).ToList();
        }
    }
}
