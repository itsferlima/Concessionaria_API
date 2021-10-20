using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Data;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly DataContext _context;
        public UsuarioController(DataContext context)
        {
            _context = context;
        }
    
        //POST: api/usuario/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Created ("", usuario);
        }

        //GET: api/usuario/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Usuarios.ToList());

        //GET api/usuario/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById ([FromRoute] int id)
        {
            Usuario usuario = _context.Usuarios.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        //DELETE: api/usuario/delete/Felipe
        [HttpDelete]
        [Route("delete/{id}")]// ver esse name ou marca
        public IActionResult Delete ([FromRoute] int Id )
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(usuario =>usuario.Id == Id);

            if(usuario == null)
            {
                return NotFound();    
            }
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return Ok(_context.Usuarios.ToList());
        }

        //PUT api/usuario/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update ([FromBody] Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }    
    }
}