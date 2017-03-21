namespace RescueDog.IncomingService.Db
{
	using System;
	using Microsoft.EntityFrameworkCore;
	using RescueDog.IncomingService.Models;

	public class IncomingDbContext : DbContext
	{
		public DbSet<IncomingDog> IncomingDogs { get; set; }
	}
}