using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using mvc3_WEB_API.Models;

namespace mvc3_WEB_API.Controllers
{
    public class Default1Controller : ApiController
    {
        private mvc3_WEB_APIContext db = new mvc3_WEB_APIContext();

        // GET api/Default1
        public IEnumerable<Person> GetPeople()
        {
            return db.People.AsEnumerable();
        }

        // GET api/Default1/5
        public Person GetPerson(int id)
        {
            Person person = db.People.Find(id);
            if (person == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return person;
        }

        // PUT api/Default1/5
        public HttpResponseMessage PutPerson(int id, Person person)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != person.ID)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(person).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/Default1
        public HttpResponseMessage PostPerson(Person person)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(person);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, person);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = person.ID }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/Default1/5
        public HttpResponseMessage DeletePerson(int id)
        {
            Person person = db.People.Find(id);
            if (person == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.People.Remove(person);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, person);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}