﻿using MovieApi.Application.Features.CQRSdesingPattern.Commands.CategoryCommands;
using MovieApi.Application.Features.CQRSdesingPattern.Commands.MovieCommands;
using MovieApi.Persistence.Context;
using MovieAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSdesingPattern.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public CreateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateMovieCommand command)
        {
            _context.Movies.Add(new Movie
            {
                CoverImageUrl = command.CoverImageUrl,
                CreatedYear = command.CreatedYear,
                Description = command.Description,
                Duration = command.Duration,                
                Rating = command.Rating,
                ReleaseDate = command.ReleaseDate,
                Status = command.Status,
                MovieTitle = command.MovieTitle
            });
            await _context.SaveChangesAsync();
        }
    }
}
