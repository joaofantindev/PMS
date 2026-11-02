using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace copySystem.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public float Preco { get; set; }
        public int QtdeStoque { get; set; }
    }
}