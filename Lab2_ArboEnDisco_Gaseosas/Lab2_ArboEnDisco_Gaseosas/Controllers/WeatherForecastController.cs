using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lab2_ArboEnDisco_Gaseosas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        List<Gaseosa> lista = new List<Gaseosa>();
    
        [HttpGet]
        public IEnumerable<Gaseosa> Get()
        {

            return lista;
        }

        // GET api/values/5
        [HttpGet("{id?}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IEnumerable<Gaseosa> Post([FromBody] Gaseosa bebida)
        {
            string a = "";
            string b = "";
            Data.Instance.Arbolito1.Agregar(a, bebida, b);
            return lista;
        }

    }
}
