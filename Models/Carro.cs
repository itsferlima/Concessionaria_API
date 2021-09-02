using System;

namespace API.Models
{
    public class Carro
    {
        public Carro() => CriadoEm = DateTime.Now; // pega data/hora atual
        public int Id {get; set;}
        public string Marca {get; set;}
        public double Valor {get; set;}
        public DateTime CriadoEm {get; set;}

        public override string ToString() =>
        $"Marca: {Marca} | Valor: {Valor.ToString("C2")} | Criado em: {CriadoEm} | ID: {Id}";
    }
}