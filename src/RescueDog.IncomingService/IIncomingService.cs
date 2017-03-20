namespace RescueDog.IncomingService
{
	using System.Linq;
	using RescueDog.IncomingService.Models;

	/// <summary>
	/// Manages incoming dogs
	/// </summary>
	public interface IIncomingService
	{
		/// <summary>
		/// Gets the incoming dogs.
		/// </summary>
		/// <returns>The incoming dogs.</returns>
		IQueryable<IncomingDog> GetIncomingDogs();

		/// <summary>
		/// Gets the incoming dog.
		/// </summary>
		/// <returns>The incoming dog.</returns>
		/// <param name="id">The incoming dog ID.</param>
		IncomingDog GetIncomingDog(string id);

		/// <summary>
		/// Adds the incoming dog.
		/// </summary>
		/// <returns>The added incoming dog.</returns>
		/// <param name="request">The incoming dog details.</param>
		IncomingDog AddIncomingDog(IncomingDogRequest request);

		/// <summary>
		/// Updates the incoming dog.
		/// </summary>
		/// <returns>The updated incoming dog.</returns>
		/// <param name="updates">The updated incoming dog.</param>
		IncomingDog UpdateIncomingDog(IncomingDogUpdates updates);

		/// <summary>
		/// Sets the contact ID for an incoming dog..
		/// </summary>
		/// <param name="id">The incoming dog ID.</param>
		/// <param name="contactId">The contact member ID.</param>
		void SetContact(string id, string contactId);

		/// <summary>
		/// Resolves the incoming dog.
		/// </summary>
		/// <param name="id">The incoming dog ID.</param>
		/// <param name="resolution">The incoming dog resolution.</param>
		void ResolveIncomingDog(string id, IncomingResolutionDetails resolution);

		/// <summary>
		/// Removes an incoming dog completely.
		/// </summary>
		/// <returns>The removed details.</returns>
		/// <param name="id">The incoming dog ID.</param>
		IncomingDog RemoveIncomingDog(string id);
	}
}
