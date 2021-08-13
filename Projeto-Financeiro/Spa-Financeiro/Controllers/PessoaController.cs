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
    public class PessoaController : ApiController
    {
        private BD db = new BD();

        // GET: api/Pessoa
        public IQueryable<Pessoa> GetPessoas()
        {
            return db.Pessoa;
        }

        // GET: api/Pessoa/5
        [ResponseType(typeof(Pessoa))]
        public async Task<IHttpActionResult> GetPessoa(int id)
        {
            Pessoa pessoa = await db.Pessoa.FindAsync(id);
            if (pessoa == null)
            {
                return NotFound();
            }

            return Ok(pessoa);
        }

        // PUT: api/Pessoa/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPessoa(int id, Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pessoa.Id)
            {
                return BadRequest();
            }

            db.Entry(pessoa).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaExists(id))
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

        // POST: api/Pessoa
        [ResponseType(typeof(Pessoa))]
        public async Task<IHttpActionResult> PostPessoa(Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pessoa.Add(pessoa);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = pessoa.Id }, pessoa);
        }

        // DELETE: api/Pessoa/5
        [ResponseType(typeof(Pessoa))]
        public async Task<IHttpActionResult> DeletePessoa(int id)
        {
            Pessoa pessoa = await db.Pessoa.FindAsync(id);
            if (pessoa == null)
            {
                return NotFound();
            }

            db.Pessoa.Remove(pessoa);
            await db.SaveChangesAsync();

            return Ok(pessoa);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PessoaExists(int id)
        {
            return db.Pessoa.Count(e => e.Id == id) > 0;
        }
    }
}