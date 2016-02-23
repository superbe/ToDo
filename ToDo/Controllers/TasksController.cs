using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ToDo.Core;
using ToDo.Models;

namespace ToDo.Controllers
{
	public class TasksController : ApiController
	{
		//private ApplicationDbContext db = new ApplicationDbContext();

		//// GET: api/Tasks
		//public IEnumerable<Task> GetTasks()
		//{
		//	return db.Tasks.ToList();
		//}

		//// POST api/Tasks/Search
		//[Route("Search")]
		//public IEnumerable<Task> Search(string text, int filter)
		//{
		//	var userName = RequestContext.Principal.Identity.Name;
		//	ApplicationUser user = db.Users.FirstOrDefault(x => x.Email == userName);

		//	List<Task> result = string.IsNullOrWhiteSpace(text) ? db.Tasks.Where(x => x.Owner == user.Id).ToList() : db.Tasks.Where(x => x.Owner == user.Id && (x.Title.Contains(text) || x.Description.Contains(text))).ToList();
		//	//switch(filter) {
		//	//	case 0: return result.OrderBy(x => x.ImportanceID);
		//	//	case 1: return result.OrderBy(x => x.Created);
		//	//	default:
		//	return result;
		//	//}
		//}

		//// GET: api/Tasks/5
		//[ResponseType(typeof(Task))]
		//public IHttpActionResult GetTask(int id)
		//{
		//	Task task = db.Tasks.Find(id);
		//	if (task == null)
		//	{
		//		return NotFound();
		//	}

		//	return Ok(task);
		//}

		//// PUT: api/Tasks/5
		//[ResponseType(typeof(void))]
		//public IHttpActionResult PutTask(string id, Task task)
		//{
		//	if (!ModelState.IsValid)
		//	{
		//		return BadRequest(ModelState);
		//	}

		//	if (id != task.Id.ToString())
		//	{
		//		return BadRequest();
		//	}

		//	db.Entry(task).State = EntityState.Modified;

		//	try
		//	{
		//		db.SaveChanges();
		//	}
		//	catch (DbUpdateConcurrencyException)
		//	{
		//		if (!TaskExists(id))
		//		{
		//			return NotFound();
		//		}
		//		else
		//		{
		//			throw;
		//		}
		//	}

		//	return StatusCode(HttpStatusCode.NoContent);
		//}

		//// POST: api/Tasks
		//[ResponseType(typeof(Task))]
		//public IHttpActionResult PostTask(Task task)
		//{
		//	if (!ModelState.IsValid)
		//	{
		//		return BadRequest(ModelState);
		//	}

		//	db.Tasks.Add(task);
		//	db.SaveChanges();

		//	return CreatedAtRoute("DefaultApi", new { id = task.Id }, task);
		//}

		//// DELETE: api/Tasks/5
		//[ResponseType(typeof(Task))]
		//public IHttpActionResult DeleteTask(int id)
		//{
		//	Task task = db.Tasks.Find(id);
		//	if (task == null)
		//	{
		//		return NotFound();
		//	}

		//	db.Tasks.Remove(task);
		//	db.SaveChanges();

		//	return Ok(task);
		//}

		//protected override void Dispose(bool disposing)
		//{
		//	if (disposing)
		//	{
		//		db.Dispose();
		//	}
		//	base.Dispose(disposing);
		//}

		//private bool TaskExists(string id)
		//{
		//	return db.Tasks.Count(e => e.Id.ToString() == id) > 0;
		//}
	}
}