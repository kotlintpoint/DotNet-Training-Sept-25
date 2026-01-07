using Learning.Data;
using Learning.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<List<Activity>>
        {         
        }

        public class Handler : IRequestHandler<Query, List<Activity>>
        {
            private readonly ApplicationDbContext _db;
            public Handler(ApplicationDbContext db)
            {
                _db = db;
            }
            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _db.Activities.ToListAsync();
            }
        }
    }
}
