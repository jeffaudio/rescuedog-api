namespace RescueDog.Db
{
	using System;
	using Microsoft.EntityFrameworkCore;
	using RescueDog.Db.Models;

	/// <summary>
	/// Rescue dog db context.
	/// </summary>
	public class RescueDogDbContext : DbContext
	{
		public DbSet<IncomingDog> IncomingDogs { get; set; }
	}
}
