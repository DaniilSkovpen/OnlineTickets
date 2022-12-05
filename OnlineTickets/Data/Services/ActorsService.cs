using Microsoft.EntityFrameworkCore;
using OnlineTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDBContext _context;
        public ActorsService(AppDBContext context)
        {
            _context = context;
        }

        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var resoult = await _context.Actors.ToListAsync();
            return resoult;
        }

        public Actor GetBy(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
