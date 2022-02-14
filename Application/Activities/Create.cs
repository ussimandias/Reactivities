using Domain;
using FluentValidation;
using MediatR;
using Persistence;

public class Create
{
    public class Command : IRequest<Result<Unit>>
    {
        public Activity Activity{ get; set;}

    }

    public class CommandValidator : AbstractValidator<Command>
    {
        public CommandValidator()
        {
            RuleFor(x => x.Activity).SetValidator( new ActivityValidator());
        }
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
            dataContext.Activities.Add(request.Activity);

            var result = await dataContext.SaveChangesAsync() > 0;
            if (!result)
            {
                return Result<Unit>.Failure("Failed to create activity");
            }
            return Result<Unit>.Sucess(Unit.Value);
        }
    }
}