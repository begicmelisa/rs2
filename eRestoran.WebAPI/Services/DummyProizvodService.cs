using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model;

namespace eRestoran.WebAPI.Services
{
    public class DummyProizvodService : IProizvodService
    {
        public IList<Proizvod> Get()
        {
            throw new NotImplementedException();
        }
    }
}
