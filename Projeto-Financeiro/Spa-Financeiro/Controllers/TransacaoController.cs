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
using business.Classe;
using business.banco;

namespace Spa_Financeiro.Controllers
{
    public class TransacaoController : ApiController
    {
        private BD db = new BD();

        // GET: api/Transacao
        public IQueryable<Transacao> GetMovimentacao()
        {
            return db.Transacao;
        }

        // GET: api/Transacao/5
        [ResponseType(typeof(Transacao))]
        public async Task<IHttpActionResult> GetTransacao(int id)
        {
            Transacao transacao = await db.Transacao.FindAsync(id);
            if (transacao == null)
            {
                return NotFound();
            }

            return Ok(transacao);
        }

        // PUT: api/Transacao/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTransacao(int id, Transacao transacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != transacao.Id)
            {
                return BadRequest();
            }

            db.Entry(transacao).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransacaoExists(id))
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

        // POST: api/Transacao
        [ResponseType(typeof(Transacao))]
        public async Task<IHttpActionResult> PostTransacao(Transacao transacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Movimentacao.Add(transacao);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = transacao.Id }, transacao);
        }

        // DELETE: api/Transacao/5
        [ResponseType(typeof(Transacao))]
        public async Task<IHttpActionResult> DeleteTransacao(int id)
        {
            Transacao transacao = await db.Transacao.FindAsync(id);
            if (transacao == null)
            {
                return NotFound();
            }

            db.Movimentacao.Remove(transacao);
            await db.SaveChangesAsync();

            return Ok(transacao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TransacaoExists(int id)
        {
            return db.Movimentacao.Count(e => e.Id == id) > 0;
        }
    }
}