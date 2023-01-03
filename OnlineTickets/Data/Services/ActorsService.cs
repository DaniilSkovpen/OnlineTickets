using Microsoft.EntityFrameworkCore;
using OnlineTickets.Models;
using System;
using System.Collections.Generic;
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
            _context.Actors.Add(actor);
            _context.SaveChanges();

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
