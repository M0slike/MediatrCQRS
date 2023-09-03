namespace MediatR.Contracts.CQRS
{
	public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
		where TQuery : IQuery<TResponse>
	{
	}
}