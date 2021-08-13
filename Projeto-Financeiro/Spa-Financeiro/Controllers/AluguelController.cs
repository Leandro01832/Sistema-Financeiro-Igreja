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
using business.Classe;
using business.banco;

namespace Spa_Financeiro.Controllers
{
    public class AluguelController : ApiController
    {
        private BD db = new BD();

        // GET: api/Aluguel
        public IQueryable<Aluguel> GetMovimentacao()
        {
            return db.Aluguel;
        }

        // GET: api/Aluguel/5
        [ResponseType(typeof(Aluguel))]
        public IHttpActionResult GetAluguel(int id)
        {
            Aluguel aluguel = db.Aluguel.Find(id);
            if (aluguel == null)
            {
                return NotFound();
            }

            return Ok(aluguel);
        }

        // PUT: api/Aluguel/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAluguel(int id, Aluguel aluguel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aluguel.Id)
            {
                return BadRequest();
            }

            db.Entry(aluguel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AluguelExists(id))
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

        // POST: api/Aluguel
        [ResponseType(typeof(Aluguel))]
        public IHttpActionResult PostAluguel(Aluguel aluguel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Movimentacao.Add(aluguel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = aluguel.Id }, aluguel);
        }

        // DELETE: api/Aluguel/5
        [ResponseType(typeof(Aluguel))]
        public IHttpActionResult DeleteAluguel(int id)
        {
            Aluguel aluguel = db.Aluguel.Find(id);
            if (aluguel == null)
            {
                return NotFound();
            }

            db.Movimentacao.Remove(aluguel);
            db.SaveChanges();

            return Ok(aluguel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AluguelExists(int id)
        {
            return db.Movimentacao.Count(e => e.Id == id) > 0;
        }
    }
}