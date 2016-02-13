﻿using System;
using System.Web.Http;

namespace ToDo.Controllers
{
	[Authorize]
	public class ValuesController : ApiController
	{
		// GET api/values
		public string Get()
		{
			var userName = this.RequestContext.Principal.Identity.Name;
			return String.Format("Hello, {0}.", userName);
		}
	}
}
