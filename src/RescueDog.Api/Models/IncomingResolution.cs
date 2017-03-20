namespace RescueDog.Api.Models
{
	/// <summary>
	/// Incoming dog resolution
	/// </summary>
	public enum IncomingResolution
	{
		/// <summary>
		/// GLBCR foster
		/// </summary>
		GlbcrFoster,

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