using Learning.Data;
using Learning.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities
{
    public class Create
    {
        public class Command : IRequest
        { 
            public Activity Activity { get; set; }
        }
        public class Handler : IRequestHandler<Command>
        {
            private readonly ApplicationDbContext _db;
            public Handler(ApplicationDbContext db)
            {
                _db = db;
            }
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                await _db.Activities.AddAsync(request.Activity);
                _db.SaveChanges();
                return;
            }
        }
    }
}
