using Application.Core;
using Learning.Data;
using Learning.Models;
using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Activities
{
    public class Create
    {
        public class Command : IRequest<Result<Activity>>
        { 
            public Activity Activity { get; set; }
        }
        public class Handler : IRequestHandler<Command, Result<Activity>>
        {
            private readonly ApplicationDbContext _db;
            public Handler(ApplicationDbContext db)
            {
                _db = db;
            }
            public async Task<Result<Activity>> Handle(Command request, CancellationToken cancellationToken)
            {
                EntityEntry<Activity> entity = await _db.Activities.AddAsync(request.Activity);
                var result = _db.SaveChanges() > 0;
                if (!result) {
                    return Result<Activity>.Failure("Failed to create Activity");
                }
                return Result<Activity>.Success(entity.Entity);
            }
        }
    }
}
