using System;

namespace API.Models
{
    public class Carro 
    {
        public Carro() => CriadoEm = DateTime.Now; // pega data/hora atual
        public int Id {get; set;}
        public string Marca {get; set;}
        public double Valor {get; set;}
        public int BuyId {get; set;}  // relacionamento 
        public DateTime CriadoEm {get; set;}

        public override string ToString() =>
        $"Id: {Id} | Marca: {Marca} | Valor: {Valor.ToString("C2")} | Id da compra: {BuyId} | Criado em: {CriadoEm}";
    }
}