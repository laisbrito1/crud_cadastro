using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_SIMPLES_PRODUTOS
{


    public class Produto
    {
        public int ID { get; set; }
        public string? Nome { get; set; }
    }
}