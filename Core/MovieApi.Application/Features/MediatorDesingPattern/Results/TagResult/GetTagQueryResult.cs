﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesingPattern.Results.TagResult
{
    public class GetTagQueryResult
    {
        public int TagId { get; set; }
        public string Title { get; set; }
    }
}
