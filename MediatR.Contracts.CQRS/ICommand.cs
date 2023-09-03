namespace MediatR.Contracts.CQRS
{
	public interface ICommand : IRequest
	{
	}

	public interface ICommand<out TResponse> : IRequest<TResponse>
	{
	}
}