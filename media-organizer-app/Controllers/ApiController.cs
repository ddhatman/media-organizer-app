using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace media_organizer_app.Controllers {
	[Route("[controller]")]
	[ApiController]
	public class ApiController : ControllerBase {
		[HttpGet]
		public string Get() {
			return "yo yo yo";
		}
	}
}