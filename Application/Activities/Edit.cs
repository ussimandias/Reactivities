using AutoMapper;
using Domain;
using MediatR;
using Persistence;

public class Edit
{
    public class Command : IRequest
    {
        public Activity Activity { get; set; }
    }

    public class Handler : IRequestHandler<Command>
    {
        private readonly DataContext dataContext;
        private readonly IMapper mapper;

        public Handler(DataContext dataContext, IMapper mapper)
        {
            this.mapper = mapper;
            this.dataContext = dataContext;
        }

        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var activity = await dataContext.Activities.FindAsync(request.Activity.Id);

            //activity.Title = request.Activity.Title ?? activity.Title;
            mapper.Map(request.Activity, activity);

            await dataContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}