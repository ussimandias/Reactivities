using MediatR;
using Persistence;

public class Delete
{
    public class Command : IRequest<Result<Unit>>
    {
        public Guid Id { get; set; }
    }

    public class Handler : IRequestHandler<Command, Result<Unit>>
    {
        private readonly DataContext dataContext;
       
        public Handler(DataContext dataContext)
        {
            this.dataContext = dataContext;
            
        }

        public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
        {
            var activity = await dataContext.Activities.FindAsync(request.Id);

            if(activity ==  null) return null;

            dataContext.Remove(activity);

            var result = await dataContext.SaveChangesAsync() > 0;

            if(!result) return Result<Unit>.Failure("Failed to delete the activity");

            return Result<Unit>.Success(Unit.Value);
        }
    }
}