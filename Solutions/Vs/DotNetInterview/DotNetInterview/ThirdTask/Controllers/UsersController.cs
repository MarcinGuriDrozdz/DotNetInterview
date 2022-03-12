namespace ThirdTask.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.EntityFrameworkCore;
	using SecondTask.Models;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using ThirdTask.Dtos;

	[ApiController]
	public class UsersController
	{
		private readonly DatabaseContext _DatabaseContext;

		public UsersController(
			DatabaseContext databaseContext)
		{
			_DatabaseContext = databaseContext;
		}


		//3. Add a GET '/users' endpoint that will return a list of users with their projects.
		//[HttpGet("users")]


		//5. Add a POST '/users' endpoint that will add new user to database.
		//[HttpPost("users")]
	}
}
