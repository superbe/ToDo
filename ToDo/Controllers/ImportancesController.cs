using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using ToDo.Core;
using ToDo.Models;

namespace ToDo.Controllers
{
	public class ImportancesController : ApiController
	{
		//private ApplicationDbContext db = new ApplicationDbContext();

		//// GET: api/Importances
		//public IEnumerable<Importance> GetImportances()
		//{
		//	return db.Importances.ToList();
		//}

		//// GET: api/Importances/5
		//[ResponseType(typeof(Importance))]
		//public IHttpActionResult GetImportance(int id)
		//{
		//	Importance importance = db.Importances.Find(id);
		//	if (importance == null)
		//	{
		//		return NotFound();
		//	}

		//	return Ok(importance);
		//}

		//// PUT: api/Importances/5
		//[ResponseType(typeof(void))]
		//public IHttpActionResult PutImportance(int id, Importance importance)
		//{
		//	if (!ModelState.IsValid)
		//	{
		//		return BadRequest(ModelState);
		//	}

		//	if (id != importance.Id)
		//	{
		//		return BadRequest();
		//	}

		//	db.Entry(importance).State = EntityState.Modified;

		//	try
		//	{
		//		db.SaveChanges();
		//	}
		//	catch (DbUpdateConcurrencyException)
		//	{
		//		if (!ImportanceExists(id))
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

		//// POST: api/Importances
		//[ResponseType(typeof(Importance))]
		//public IHttpActionResult PostImportance(Importance importance)
		//{
		//	if (!ModelState.IsValid)
		//	{
		//		return BadRequest(ModelState);
		//	}

		//	db.Importances.Add(importance);
		//	db.SaveChanges();

		//	return CreatedAtRoute("DefaultApi", new { id = importance.Id }, importance);
		//}

		//// DELETE: api/Importances/5
		//[ResponseType(typeof(Importance))]
		//public IHttpActionResult DeleteImportance(int id)
		//{
		//	Importance importance = db.Importances.Find(id);
		//	if (importance == null)
		//	{
		//		return NotFound();
		//	}

		//	db.Importances.Remove(importance);
		//	db.SaveChanges();

		//	return Ok(importance);
		//}

		//protected override void Dispose(bool disposing)
		//{
		//	if (disposing)
		//	{
		//		db.Dispose();
		//	}
		//	base.Dispose(disposing);
		//}

		//private bool ImportanceExists(int id)
		//{
		//	return db.Importances.Count(e => e.Id == id) > 0;
		//}
	}
}