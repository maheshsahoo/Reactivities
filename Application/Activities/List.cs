using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Activities
{
    public class List
    {
        public class Query: IRequest<List<Activity>>{}

        public class Handler : IRequestHandler<Query, List<Activity>>
        {
        public DataContext _context { get; }
        private readonly ILogger<List> _logger;
            public Handler(DataContext context, ILogger<List> logger)
            {
            _logger = logger;
            _context = context;

            }

            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
               
                return await _context.Activities.ToListAsync();
            }
        }
    }
}