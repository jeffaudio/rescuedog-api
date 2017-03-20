namespace RescueDog.Api.Models
{
	using System;

	/// <summary>
	/// The rescue dog age range.
	/// </summary>
	[Flags]
	public enum AgeRange
	{
		/// <summary>
		/// A puppy (0 to 6 months).
		/// </summary>
		Puppy = 1,

		/// <summary>
		/// A young dog (6 months to 2 years).
		/// </summary>
		Young = 2,

		/// <summary>
		/// An adult dog (2 years to 5 years).
		/// </summary>
		Adult = 4,

		/// <summary>
		/// An experienced dog (5+ years).
		/// </summary>
		Senior = 8
	}
}