using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Database;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
    public class VrsteProizvodaController : BaseController<Model.VrsteProizvoda, object>
    {
        public VrsteProizvodaController(IService<Model.VrsteProizvoda, object> service) : base(service)
        {
        }
    }
}