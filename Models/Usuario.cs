using System;
using System.Collections.Generic;

namespace API.Models
{
    public class Usuario
    {
        public Usuario() => CriadoEm = DateTime.Now; // pega data/hora atual
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public DateTime CriadoEm {get; set;}
    }
}