using System;

namespace projeto
{
    public class Produto
    {
        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Marca{get;set;}
        public float preco { get; set; }
        public DateTime Data { get; }
        public Produto(int _codigo, string _nome, string _marca, float _preco, DateTime _data)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Marca = _marca;
            this.preco = _preco;
            this. Data = _data;

        }
    }
}