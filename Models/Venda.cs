using System;
using System.Collections.Generic;

namespace API.Models
{
    public class Venda
    {
        public Venda () => CriadoEm = DateTime.Now;
        public int Id {get; set;}
        public string Usuario {get;set;}
        public List<Itens> Itens {get; set;}
        public DateTime CriadoEm{ get; set;}
    }
}   