using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodController : ControllerBase
    {
        private readonly IProizvodService _proizvodService;
        public ProizvodController(IProizvodService proizvodService)
        {
            _proizvodService = proizvodService;
        }
        [HttpGet]
        public ActionResult<IList<Proizvod>> Get()
        {
            var list= _proizvodService.Get();
            return Ok(list);
        }
        [HttpGet("{id}")]
        public ActionResult<Proizvod> GetById(int id)
        {
            var item = new Proizvod()
             {
                 ProizvodID = 1,
                 Naziv = "Lapotp"
             };
            
            return item;
        }

        [HttpPost]
        public Proizvod Insert(Proizvod proizvod)
        {
            return new Proizvod()
            {
                ProizvodID = -1,
                Naziv = proizvod.Naziv
            };
        }


        [HttpPut("{id}")]
        public Proizvod Update(int id, Proizvod proizvod)
        {
            return new Proizvod()
            {
                ProizvodID = id,
                Naziv = proizvod.Naziv
            };
        }
    }
}