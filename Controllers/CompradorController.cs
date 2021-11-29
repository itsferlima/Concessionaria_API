// using System;
// using System.Linq;
// using API.Data;
// using API.Models;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;

// namespace API.Controllers
// {
//     [ApiController]
//     [Route("api/comprador")]
//     public class compradorController : ControllerBase
//     {
//         private readonly DataContext _context;
        
//         public CompradorController(DataContext context)
//         {
//             _context = context;
//         }
//         //POST: api/comprador/create
//         [HttpPost] 
//         [Route("create")]
//         public IActionResult Create([FromBody] Comprador comprador)
//         {
//            Comprador compradorExistente = _context.Comprador.FirstOrDefault( c => c.Email == comprador.Email);
//             if (compradorExistente != null)
//             {
//                 return BadRequest(new { message = "Este e-mail já está em uso" });
//             }
//             _context.Comprador.Add(comprador);
//             _context.SaveChanges();
//             comprador.Senha = "";
//             return Created("", comprador);
//         }

//         // GET: api/comprador/login
//         [HttpGet]
//         [Route("login")]
//         public IActionResult Login([FromBody] Comprador comprador)
//         {
//             comprador = _context.comprador.FirstOrDefault
//                 (c => c.Email == comprador.Email && u.Senha == comprador.Senha);
//             if (comprador == null)
//             {
//                 return NotFound(new { message = "Usuário ou senha inválidos" });
//             }

//             comprador.Token = TokenService.CriarToken(comprador);
//             comprador.Senha = "";
//             return Ok(comprador);
//         }

//         // // GET: api/comprador/sem
//         // [HttpGet]
//         // [Route("sem")]
//         // [AllowAnonymous]
//         // public IActionResult Sem()
//         // {
//         //     return Ok(new { message = "Sem autenticação" });
//         // }

//         // // GET: api/comprador/com
//         // [HttpGet]
//         // [Route("com")]
//         // [Authorize]
//         // public IActionResult Com()
//         // {
//         //     Comprador comprador = _context.Comprador.FirstOrDefault(u => u.Email == User.Identity.Name);
//         //     return Ok(new { identity = User.Identity.Name, user = comprador });
//         // }

//         // // GET: api/comprador/permissao
//         // [HttpGet]
//         // [Route("permissao")]
//         // [Authorize(Roles = "adm")]
//         // public IActionResult Permissao()
//         // {
//         //     return Ok(new { message = "Administrador" });
//         // }
//     }
// }