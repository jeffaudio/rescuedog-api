namespace RescueDog.IncomingService.Models
{
	using System;
	using RescueDog.Common.Models;

	/// <summary>
	/// Represents a potential foster dog.
	/// </summary>
	public class IncomingDogUpdates
	{
		/// <summary>
		/// Gets or sets the name of the dog.
		/// </summary>
		/// <value>The dog's incoming name.</value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the dog's current setting.
		/// </summary>
		/// <value>The dog's current setting.</value>
		public string CurrentSetting { get; set; }

		/// <summary>
		/// Gets or sets the urgency of the dog's situation.
		/// </summary>
		/// <value>The request urgency.</value>
		public ReleaseUrgency Urgency { get; set; }

		/// <summary>
		/// Gets or sets the date the dog must be moved by.
		/// </summary>
		/// <value>The dog's must move by date.</value>
		public DateTimeOffset MustMoveByDate { get; set; }

		/// <summary>
		/// Gets or sets the gender of the dog.
		/// </summary>
		/// <value>The dog's gender.</value>
		public Gender Gender { get; set; }

		/// <summary>
		/// Gets or sets the age range.
		/// </summary>
		/// <value>The dog's age range.</value>
		public AgeRange Age { get; set; }

		/// <summary>
		/// Gets or sets the request source for the dog.
		/// </summary>
		/// <value>The source of the request.</value>
		public string RequestSource { get; set; }

		/// <summary>
		/// Gets or sets the dog's current city.
		/// </summary>
		/// <value>The city where the dog is located.</value>
		public string City { get; set; }

		/// <summary>
		/// Gets or sets the dog's current state.
		/// </summary>
		/// <value>The state where the dog is located.</value>
		public string State { get; set; }

		/// <summary>
		/// Gets or sets the contact user identifier.
		/// </summary>
		/// <value>The contact user identifier.</value>
		public string ContactUserId { get; set; }

		/// <summary>
		/// Gets or sets the dog's physical description.
		/// </summary>
		/// <value>The dog's physical description.</value>
		public string PhysicalDescription { get; set; }

		/// <summary>
		/// Gets or sets the dog's traits.
		/// </summary>
		/// <value>The dog's traits.</value>
		public string Traits { get; set; }

		/// <summary>
		/// Gets or sets the notes.
		/// </summary>
		/// <value>The notes.</value>
		public string Notes { get; set; }

		/// <summary>
		/// Gets or sets the relinquish form URL.
		/// </summary>
		/// <value>The relinquish form URL.</value>
		public Uri RelinquishFormUrl { get; set; }

		/// <summary>
		/// Gets or sets the resolution.
		/// </summary>
		/// <value>The resolution.</value>
		public ResolutionType Resolution { get; set; }

		/// <summary>
		/// Gets or sets the resolution date.
		/// </summary>
		/// <value>The resolution date.</value>
		public DateTimeOffset ResolutionDate { get; set; }

		/// <summary>
		/// Gets or sets the resolution notes.
		/// </summary>
		/// <value>The resolution notes.</value>
		public string ResolutionNotes { get; set; }
	}
}