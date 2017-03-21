namespace RescueDog.IncomingService
{
	using System;
	using System.Linq;
	using Models;
	using RescueDog.IncomingService.Db;
	using RescueDog.IncomingService.Exceptions;

	public class IncomingService : IIncomingService
	{
		private readonly IncomingDbContext db;

		/// <summary>
		/// Adds the incoming dog.
		/// </summary>
		/// <returns>The added incoming dog.</returns>
		/// <param name="request">The incoming dog request.</param>
		public IncomingDog AddIncomingDog(IncomingDogRequest request)
		{
			var dog = new IncomingDog
			{
				Id = Guid.NewGuid().ToString(),
				Name = request.Name,
				DateCreated = DateTimeOffset.UtcNow,
				DateModified = DateTimeOffset.UtcNow,
				// ModifiedUserId
				CurrentSetting = request.CurrentSetting,
				Urgency = request.Urgency,
				MustMoveByDate = request.MustMoveByDate,
				Gender = request.Gender,
				Age = request.Age,
				RequestSource = request.RequestSource,
				City = request.City,
				State = request.State,
				ContactUserId = request.ContactUserId,
				PhysicalDescription = request.PhysicalDescription,
				Traits = request.Traits,
				Notes = request.Notes,
				RelinquishFormUrl = request.RelinquishFormUrl,
				Resolution = request.Resolution,
				ResolutionDate = request.ResolutionDate,
				ResolutionNotes = request.ResolutionNotes
			};

			this.db.IncomingDogs.Add(dog);
			this.db.SaveChanges();
			return dog;
		}

		/// <summary>
		/// Gets a specific incoming dog record.
		/// </summary>
		/// <returns>The incoming dog, or null if it doesn't exist.</returns>
		/// <param name="id">the incoming dog's dentifier.</param>
		public IncomingDog GetIncomingDog(string id)
		{
			return this.db.IncomingDogs.SingleOrDefault(d => d.Id == id);
		}

		/// <summary>
		/// Gets the incoming dogs.
		/// </summary>
		/// <returns>An IQueryable of the incoming dogs.</returns>
		public IQueryable<IncomingDog> GetIncomingDogs()
		{
			return this.db.IncomingDogs.AsQueryable();
		}

		/// <summary>
		/// Removes the incoming dog.
		/// </summary>
		/// <returns>The incoming dog.</returns>
		/// <param name="id">The incoming dog identifier.</param>
		public IncomingDog RemoveIncomingDog(string id)
		{
			var dog = this.GetIncomingDog(id);

			if (dog != null)
			{
				this.db.IncomingDogs.Remove(dog);
				this.db.SaveChanges();
			}

			return dog;
		}

		/// <summary>
		/// Resolves the incoming dog.
		/// </summary>
		/// <param name="id">The incoming dog identifier.</param>
		/// <param name="resolution">The dog's resolution details.</param>
		public IncomingDog ResolveIncomingDog(string id, IncomingResolutionDetails resolution)
		{
			var dog = this.GetIncomingDog(id);
			if (dog == null)
			{
				throw new IncomingDogNotFoundException(id);
			}

			dog.Resolution = resolution.Resolution;
			dog.ResolutionDate = resolution.ResolutionDate;
			dog.ResolutionNotes = resolution.ResolutionNotes;
			this.db.SaveChanges();

			return dog;
		}

		public IncomingDog SetContact(string id, string contactId)
		{
			var dog = this.GetIncomingDog(id);
			if (dog == null)
			{
				throw new IncomingDogNotFoundException(id);
			}

			dog.ContactUserId = contactId;
			this.db.SaveChanges();

			return dog;
		}

		public IncomingDog UpdateIncomingDog(string id, IncomingDogUpdates updates)
		{
			var dog = this.GetIncomingDog(id);
			if (dog == null)
			{
				throw new IncomingDogNotFoundException(id);
			}

			dog.Name = updates.Name;
			dog.DateModified = DateTimeOffset.UtcNow;
			// ModifiedUserId
			dog.CurrentSetting = updates.CurrentSetting;
			dog.Urgency = updates.Urgency;
			dog.MustMoveByDate = updates.MustMoveByDate;
			dog.Gender = updates.Gender;
			dog.Age = updates.Age;
			dog.RequestSource = updates.RequestSource;
			dog.City = updates.City;
			dog.State = updates.State;
			dog.ContactUserId = updates.ContactUserId;
			dog.PhysicalDescription = updates.PhysicalDescription;
			dog.Traits = updates.Traits;
			dog.Notes = updates.Notes;
			dog.RelinquishFormUrl = updates.RelinquishFormUrl;
			dog.Resolution = updates.Resolution;
			dog.ResolutionDate = updates.ResolutionDate;
			dog.ResolutionNotes = updates.ResolutionNotes;
			this.db.SaveChanges();

			return dog;
		}
	}
}
