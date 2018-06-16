using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using lottodo_webapi2;
using System.Web.Routing;

namespace lottodo_webapi2.Controllers
{
    [RoutePrefix("api/UserDetails")]
    public class ltd_tbl_userdetailsController : ApiController
    {
        private Model1Container db = new Model1Container();

        // GET: api/ltd_tbl_userdetails
        [Route("GetUserDetails")]
        public IQueryable<ltd_tbl_userdetails> Getltd_tbl_userdetails()
        {
            return db.ltd_tbl_userdetails;
        }

        // GET: api/ltd_tbl_userdetails/5
        [ResponseType(typeof(ltd_tbl_userdetails))]
        public async Task<IHttpActionResult> Getltd_tbl_userdetails(string id)
        {
            ltd_tbl_userdetails ltd_tbl_userdetails = await db.ltd_tbl_userdetails.FindAsync(id);
            if (ltd_tbl_userdetails == null)
            {
                return NotFound();
            }

            return Ok(ltd_tbl_userdetails);
        }

        // PUT: api/ltd_tbl_userdetails/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putltd_tbl_userdetails(string id, ltd_tbl_userdetails ltd_tbl_userdetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ltd_tbl_userdetails.ltd_UserId)
            {
                return BadRequest();
            }

            db.Entry(ltd_tbl_userdetails).State = System.Data.Entity.EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ltd_tbl_userdetailsExists(id))
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

        [Route("CreateAccount")]
        [HttpPost]
        public async Task<IHttpActionResult> Postltd_tbl_userdetails(ltd_tbl_userdetails ltd_tbl_userdetails)
        {
            ltd_tbl_userdetails.ltd_UserId = ltd_tbl_userdetails.ltd_Email;
            ltd_tbl_userdetails.ltd_Active = true;
            ltd_tbl_userdetails.ltd_CreatedDate = DateTime.UtcNow;
            ltd_tbl_userdetails.ltd_ModifiedDate = DateTime.UtcNow;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ltd_tbl_userdetails.Add(ltd_tbl_userdetails);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ltd_tbl_userdetailsExists(ltd_tbl_userdetails.ltd_UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = ltd_tbl_userdetails.ltd_UserId }, ltd_tbl_userdetails);
        }

        // DELETE: api/ltd_tbl_userdetails/5
        [ResponseType(typeof(ltd_tbl_userdetails))]
        public async Task<IHttpActionResult> Deleteltd_tbl_userdetails(string id)
        {
            ltd_tbl_userdetails ltd_tbl_userdetails = await db.ltd_tbl_userdetails.FindAsync(id);
            if (ltd_tbl_userdetails == null)
            {
                return NotFound();
            }

            db.ltd_tbl_userdetails.Remove(ltd_tbl_userdetails);
            await db.SaveChangesAsync();

            return Ok(ltd_tbl_userdetails);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ltd_tbl_userdetailsExists(string id)
        {
            return db.ltd_tbl_userdetails.Count(e => e.ltd_UserId == id) > 0;
        }
    }
}