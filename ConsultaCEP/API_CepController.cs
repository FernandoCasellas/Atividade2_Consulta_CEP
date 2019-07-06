using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsultaCEP.Models;
using Microsoft.AspNetCore.Mvc;



namespace AppCep
{
    [Route("api/Endereco")]
    public class API_CepController : Controller
    {

        private readonly Context _context;

        public API_CepController(Context context)
        {
            _context = context;
        }
        //Por endereço
        [HttpGet("Enderecos")]
        public IEnumerable<CEP> GetAll()
        {
            List<CEP> ceps = _context.CEPs.ToList();
            return ceps;
        }
        //Por Cep
        [HttpGet("Enderecos/{Cep}")]
        public IEnumerable<CEP> GetPorCep(string cep)
        {
            var Cep = _context.CEPs.Where(s => s.Cep == cep);
            return Cep;
        }
        //Por Estado
        [HttpGet("EnderecosPorEstado/{uf}")]
        public IEnumerable<CEP> GetPorEstado(string uf)
        {
            List<CEP> Ceps = _context.CEPs.Where(s => s.Uf == uf).ToList();
            return Ceps;
        }
    }
}