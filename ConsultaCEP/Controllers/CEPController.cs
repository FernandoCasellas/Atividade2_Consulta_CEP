using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ConsultaCEP.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace ConsultaCEP.Controllers
{
    public class CEPController : Controller
    {
        private readonly Context _context;

        public CEPController(Context context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            //recuperar info do banco e mostra na view
            return View(_context.CEPs.ToList());
        }

        public IActionResult ConsultarCEP(CEP Ceps)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString("https://viacep.com.br/ws/"+Ceps.Cep+"/json/");
            CEP cep = JsonConvert.DeserializeObject<CEP>(json);
            _context.CEPs.Add(cep);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}