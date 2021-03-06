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
    [Route("api/carro")]
    public class CarroController : ControllerBase
    {
        private readonly DataContext _context;
        public CarroController(DataContext context)
        {
            _context = context;
        }

        //POST: api/carro/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Carro carro)
        {

            carro.Usuario = _context.Usuarios.Find(carro.UserId); // poderia ser
            _context.Carros.Add(carro);
            _context.SaveChanges();
            return Created("", carro);
        }

        //GET: api/carro/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Carros
        .Include(carro => carro.Usuario)
        //.Include(carro => carro.Venda) relacionamento e mais classes
        .ToList());

        //GET api/carro/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById ([FromRoute] int id)
        {
            Carro carro = _context.Carros.Find(id);
            if (carro==null)
            {
                return NotFound();
            }
            return Ok(carro);
        }

        //DELETE: api/carro/delete/1
        [HttpDelete]
        [Route("delete/{id}")]// ver esse name ou marca
        public IActionResult Delete ([FromRoute] int Id )
        {
            Carro carro = _context.Carros.FirstOrDefault(carro =>carro.Id == Id);

            if(carro == null) 
            {
                return NotFound();    
            }
            _context.Carros.Remove(carro);
            _context.SaveChanges();
            return Ok(_context.Carros.ToList());
        }

        //PUT api/carro/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update ([FromBody] Carro carro)
        {
            _context.Carros.Update(carro);
            _context.SaveChanges();
            return Ok(carro);
        }
    }
}