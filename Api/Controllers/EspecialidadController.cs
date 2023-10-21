using Api.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entidades;

namespace Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EspecialidadController : Controller
    {
        private readonly MyDbContext _context;
        public EspecialidadController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet(Name = "GetEspecialidad")]
        public ActionResult<IEnumerable<Especialidad>> GetAll()
        {
            return _context.Especialidades.ToList();
        }

        [HttpGet("GetByDesc/{descripcion}", Name = "GetByDesc")]
        public ActionResult<IEnumerable<Especialidad>> GetByDesc(string descripcion)
        {
            var especialidades = _context.Especialidades
                .Where(e => e.Descripcion.Contains(descripcion))
                .ToList();

            return especialidades;
        }

        [HttpGet("{ID}")]
        public ActionResult<Especialidad> GetById(int ID)
        {
            var Especialidad = _context.Especialidades.Find(ID);
            if (Especialidad == null)
            {
                return NotFound();
            }
            return Ok(Especialidad);
        }
        [HttpPost]
        public ActionResult<Especialidad> Create(Especialidad Especialidad)
        {
            _context.Especialidades.Add(Especialidad);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { ID = Especialidad.ID }, Especialidad);

        }
        [HttpPut("{ID}")]
        public ActionResult Update(int ID, Especialidad Especialidad)
        {
            if (ID != Especialidad.ID)
            {
                return BadRequest();
            }
            _context.Entry(Especialidad).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{ID}")]
        public ActionResult<Especialidad> Delete(int ID)
        {
            var Especialidad = _context.Especialidades.Find(ID);
            if (Especialidad == null)
            {
                return NotFound();
            }
            _context.Especialidades.Remove(Especialidad);
            _context.SaveChanges();
            return Ok(Especialidad);

        }
    }
}
