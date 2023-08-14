using System;

namespace BlazorApp_Razor.Shared.Entity
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
