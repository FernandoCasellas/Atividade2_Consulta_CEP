using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaCEP.Models
{
    public class CEP
    {

        public int Id{ get; set; }
        public string Cep { get; set; }
        public String Logradouro { get; set; }
        public String Bairro { get; set; }
        public String Localidade{ get; set; }
        public String Uf { get; set; }
        public String Ibge{ get; set; }
        

    }
}
