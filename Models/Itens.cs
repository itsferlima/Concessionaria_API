using System;

namespace API.Models
{
    public class Itens
    {
        public Itens () => CriadoEm = DateTime.Now;
        public int Id {get; set;}
        public Carro Carro {get; set;}
        public double Valor {get; set;}
        public int CarroId {get; set;}
        public string CarrinhoId {get; set;}
        public DateTime CriadoEm{ get; set;}
    }
}