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

        public async Task AddAsync(Actor actor)
        {
            _context.Actors.Add(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var resoult = await _context.Actors.FirstOrDefaultAsync(n => n.ActorsId == id);
            _context.Actors.Remove(resoult);
            await _context.SaveChangesAsync();
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
