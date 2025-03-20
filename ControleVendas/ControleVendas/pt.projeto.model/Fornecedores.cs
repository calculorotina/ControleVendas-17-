using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.pt.projeto.model
{
    public class Fornecedores : clientes
    {
        public  string cnpj { get; set; }
        public string cep { get; set; }
        public string numero { get; set; }
        public string estado { get; set; }
        public string complemento { get; set; }
        public string  bairro { get; set; }
        public string cidade { get; set; }
    }
}
