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
using Mini.Models;

namespace Mini.Controllers
{
    public class TicketDetailsController : ApiController
    {
        private Training_19Sep18_PuneEntities1 db = new Training_19Sep18_PuneEntities1();

        // GET: api/TicketDetails
        public IQueryable<TicketDetails> GetTicketDetails()
        {
            return db.TicketDetails;
        }

        // GET: api/TicketDetails/5
        [ResponseType(typeof(TicketDetails))]
        public IHttpActionResult GetTicketDetail(int id)
        {
            TicketDetails ticketDetail = db.TicketDetails.Find(id);
            if (ticketDetail == null)
            {
                return NotFound();
            }

            return Ok(ticketDetail);
        }

        // PUT: api/TicketDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployee(int id, TicketDetails t)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != t.ReqID)
            {
                return BadRequest();
            }

            //db.Entry(t).State = EntityState.Modified;
            db.TicketAction(id,t.managerApproval);
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TicketDetailExists(int id)
        {
            return db.TicketDetails.Count(e => e.ReqID == id) > 0;
        }
    }
}