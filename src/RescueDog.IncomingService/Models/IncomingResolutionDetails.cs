namespace RescueDog.IncomingService.Models
{
	using System;

	public class IncomingResolutionDetails
	{
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