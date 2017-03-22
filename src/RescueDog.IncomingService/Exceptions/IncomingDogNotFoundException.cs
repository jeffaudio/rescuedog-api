using System;
namespace RescueDog.IncomingService.Exceptions
{
	public class IncomingDogNotFoundException : Exception
	{
		/// <summary>
		/// Gets the ID of the incoming dog that wasn't found.
		/// </summary>
		/// <value>The not found incoming dog identifier.</value>
		public string Id { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:RescueDog.IncomingService.IncomingDogNotFoundException"/> class.
		/// </summary>
		/// <param name="id">The incoming dog's identifier.</param>
		public IncomingDogNotFoundException(string id)
			: base(string.Format("Incoming dog '{0}' not found.", id))
		{
			this.Id = id;
		}
	}
}
