using eRestoran.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public interface IProizvodService
    {
        IList<Proizvod> Get();
    }
}
