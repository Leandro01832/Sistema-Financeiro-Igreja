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
    public class MovimentacaoController : ApiController
    {
        private BD db = new BD();

        // GET: api/Movimentacao
        public IQueryable<Movimentacao> GetMovimentacao()
        {
            return db.Movimentacao;
        }

        // GET: api/Movimentacao/5
        [ResponseType(typeof(Movimentacao))]
        public async Task<IHttpActionResult> GetMovimentacao(int id)
        {
            Movimentacao movimentacao = await db.Movimentacao.FindAsync(id);
            if (movimentacao == null)
            {
                return NotFound();
            }

            return Ok(movimentacao);
        }

        // PUT: api/Movimentacao/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMovimentacao(int id, Movimentacao movimentacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != movimentacao.Id)
            {
                return BadRequest();
            }

            db.Entry(movimentacao).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovimentacaoExists(id))
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

        // POST: api/Movimentacao
        [ResponseType(typeof(Movimentacao))]
        public async Task<IHttpActionResult> PostMovimentacao(Movimentacao movimentacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Movimentacao.Add(movimentacao);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = movimentacao.Id }, movimentacao);
        }

        // DELETE: api/Movimentacao/5
        [ResponseType(typeof(Movimentacao))]
        public async Task<IHttpActionResult> DeleteMovimentacao(int id)
        {
            Movimentacao movimentacao = await db.Movimentacao.FindAsync(id);
            if (movimentacao == null)
            {
                return NotFound();
            }

            db.Movimentacao.Remove(movimentacao);
            await db.SaveChangesAsync();

            return Ok(movimentacao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MovimentacaoExists(int id)
        {
            return db.Movimentacao.Count(e => e.Id == id) > 0;
        }
    }
}