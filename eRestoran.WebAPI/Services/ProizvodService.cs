using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model;

namespace eRestoran.WebAPI.Services
{
    public class ProizvodService : IProizvodService
    {
        public IList<Proizvod> Get()
        {
            var list = new List<Proizvod>()
           {
             new Proizvod()
             {
               ProizvodID=1,
               Naziv="Lapotp"
             },
              new Proizvod()
             {
               ProizvodID=2,
               Naziv="Monitor"
             }
           };
            return list;
        }
    }
}
