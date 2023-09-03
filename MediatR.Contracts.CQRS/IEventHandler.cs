namespace MediatR.Contracts.CQRS
{
	public interface IEventHandler<in TEvent> : INotificationHandler<TEvent>
		where TEvent : IEvent
	{
	}
}