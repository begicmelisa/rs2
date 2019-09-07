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
    public class JediniceMjereController : BaseController<Model.JediniceMjere, object>
    {
        public JediniceMjereController(IService<Model.JediniceMjere, object> service) : base(service)
        {
        }
    }
}