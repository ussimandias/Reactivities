using Domain;
using MediatR;
using Persistence;

public class Details
{
    public class Query : IRequest<Result<Activity>>
    {
        public Guid Id { get; set; }
    }

    public class Handler : IRequestHandler<Query, Result<Activity>>
    {
        private readonly DataContext context;
        public Handler(DataContext context)
        {
            this.context = context;
        }

        public async Task<Result<Activity>> Handle(Query request, CancellationToken cancellationToken)
        {
            var activity = await context.Activities.FindAsync(request.Id);
            return Result<Activity>.Sucess(activity);
        }
    }
}