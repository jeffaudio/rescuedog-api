namespace RescueDog.IncomingService.Models
{
	/// <summary>
	/// Incoming dog resolution
	/// </summary>
	public enum ResolutionType
	{
		/// <summary>
		/// Foster
		/// </summary>
		Foster,

		/// <summary>
		/// Courtesy listing
		/// </summary>
		CourtesyListing,

		/// <summary>
		/// Referred to other rescue
		/// </summary>
		OtherRescue,

		/// <summary>
		/// Owner kept.
		/// </summary>
		OwnerKept,

		/// <summary>
		/// Rejected
		/// </summary>
		Rejected
	}
}