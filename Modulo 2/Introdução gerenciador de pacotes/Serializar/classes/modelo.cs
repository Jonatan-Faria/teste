using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace NewtonsoftJson.classes
{
    public class venda
    {

        public venda(int id, string produto, decimal preco)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
           
        }
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }

       
    }
}