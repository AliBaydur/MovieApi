﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.MediatorDesingPattern.Queries.CastQueries;
using MovieApi.Application.Features.MediatorDesingPattern.Results.CastResult;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesingPattern.Handlers.CastHandlers
{
    public class GetCastQueryHandler : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
    {
        private readonly MovieContext _context;

        public GetCastQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.ToListAsync();
            return values.Select(x => new GetCastQueryResult
            {
                CastId = x.CastId,
                Biography = x.Biography,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Surname = x.Surname,
                Overview = x.Overview,
                Title = x.Title
            }).ToList();
        }
    }
}
