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
    [Route("api/itens")]
    public class ItensController : ControllerBase
    {
        private readonly DataContext _context;
        public ItensController(DataContext context)
        {
            _context = context;
        }

        //POST: api/itens/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Itens itens) // ou item
        {
             if (String.IsNullOrEmpty(itens.CarrinhoId))
             {
                 itens.CarrinhoId = Guid.NewGuid().ToString();
            }
            itens.Carro = _context.Carros.Find(itens.CarroId);
            _context.Itens.Add(itens);
            _context.SaveChanges();
            return Created("", itens);
        }

        // // GET: api/item/getbycartid/XXXXX-XXXX-XXXXXXXXXXX
        // [HttpGet]
        // [Route("getbycartid/{cartid}")]
        // public IActionResult GetByCartId([FromRoute] string cartId)
        // {
        //     return Ok(_context.Itens
        //         .Include(itens => itens.Carro.Usuario)
        //         .Where(itens => itens.CarrinhoId == cartId).ToList());
        // }
    }     
}