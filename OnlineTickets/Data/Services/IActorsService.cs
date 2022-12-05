using OnlineTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTickets.Data.Services
{
    public interface IActorsService
    {
        IEnumerable<Actor> GetAll();
        Actor GetBy(int id);
        void Add(Actor actor);
        void Update(int id, Actor newActor);
        void Delete(int id);
    }
}
