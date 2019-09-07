using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.Model;
using eRestoran.Model.Requests;
using eRestoran.WebAPI.Database;
using eRestoran.WebAPI.Exceptions;

namespace eRestoran.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly ZdravaHranaContext _context;
        private readonly IMapper _mapper;
        public KorisniciService(ZdravaHranaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));

            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));

            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);
            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);

            if(request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slazu!");
            }

            entity.LozinkaHash = "test";
            entity.LozinkaSalt = "test";

            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Update(int id, KorisniciInsertRequest request)
        {
            var entity = _context.Korisnici.Find(id);

            _mapper.Map(request, entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if(request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Passwordi se ne slazu");
                }
            }
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnici>(entity);

        }
    }
}
